using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using GameTrackr.Core;
using GameTrackr.Model;
using System.Text.RegularExpressions;
using System.Threading;

namespace GameTrackr.View
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            this.Load += frmMenu_Load;
            this.bgWorker.DoWork += bgWorker_DoWork;
            this.bgWorker.RunWorkerCompleted += bgWorker_RunWorkerCompleted;
        }

        void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pbProgresso.Value = 0;
            lblProcessando.Text = "Pronto!";
            LoadCapas();
        }

        void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            LoadGames();
        }

        void frmMenu_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            Configuration.LoadConfig();
            LoadCapas();
        }

        private void btnAddBiblioteca_Click(object sender, EventArgs e)
        {
            bgWorker.RunWorkerAsync();
            //Thread th = new Thread(LoadGames);
            //th.Start();
        }

        public void LoadGames()
        {
            ToolStripButton button = new ToolStripButton();

            if (btnPsp.Checked)
                button = btnPsp;
            if (btnPSOne.Checked)
                button = btnPSOne;
            if (btnGba.Checked)
                button = btnGba;

            foreach (Platform p in Configuration.config.platforms)
            {

                if (p.name.Equals(button.Tag))
                {
                    if (p.folder == null)
                    {
                        MessageBox.Show("Pasta não definida para esta plataforma");
                        break;
                    }

                    DirectoryInfo dirInfo = new DirectoryInfo(p.folder);
                    FileInfo[] fileNames = dirInfo.GetFiles("*.*");

                    pbProgresso.Maximum = fileNames.Count();

                    //verifica se alguns arquivos foram deletados
                    List<Game> remover = new List<Game>();
                    foreach (Game g in p.games)
                        if (!File.Exists(g.path))
                            remover.Add(g);

                    foreach (Game g in remover)
                        p.games.Remove(g);

                    remover = null;

                    foreach (FileInfo a in fileNames)
                    {
                        lblProcessando.Text = "Searching metadata: " + a.Name.Replace(a.Extension, "");

                        Game gm = p.games.Where(x => x.path == a.FullName).FirstOrDefault();

                        if (gm == null)
                        {
                            gm = Wrapper.GetGame(0, a.Name.Replace(a.Extension, ""), p.name);

                            if (gm == null)
                                gm = Wrapper.GetGame(0, Regex.Replace(a.Name.Replace(a.Extension, ""), @"[\d-]", string.Empty), p.name);

                            GameImage gi = gm.GetFrontBox();
                            if (gi != null)
                            {
                                PictureBox pic = new PictureBox();
                                pic.Load(gi.original);
                                gm.cover = pic.Image;
                                gm.path = a.FullName;

                                if (p.name.Equals(button.Tag))
                                {
                                    pic = new PictureBox();
                                    pic.Image = gm.cover;
                                    pic.SizeMode = PictureBoxSizeMode.StretchImage;
                                }

                            }

                            if (gm != null)
                                p.games.Add(gm);
                        }

                        if (pbProgresso.Value < pbProgresso.Maximum)
                            pbProgresso.Value += 1;

                    }

                }

            }

            Configuration.SaveConfig();
        }

        public void LoadCapas()
        {
            flContainer.Controls.Clear();

            ToolStripButton button = new ToolStripButton();

            if (btnPsp.Checked)
                button = btnPsp;
            if (btnPSOne.Checked)
                button = btnPSOne;
            if (btnGba.Checked)
                button = btnGba;

            foreach (Platform plat in Configuration.config.platforms)
            {
                if (plat.name.Equals(button.Tag))
                {
                    foreach (Game game in plat.games)
                    {
                        PictureBox pic = new PictureBox();
                        pic.Width = plat.boxWidth;
                        pic.Height = plat.boxHeight;
                        pic.SizeMode = PictureBoxSizeMode.StretchImage;
                        pic.Image = game.cover;
                        flContainer.Controls.Add(pic);
                    }
                }
            }
        }

        private void btnPsp_Click(object sender, EventArgs e)
        {
            btnPsp.Checked = true;
            btnGba.Checked = false;
            btnPSOne.Checked = false;
            LoadCapas();
        }

        private void btnGba_Click(object sender, EventArgs e)
        {
            btnGba.Checked = true;
            btnPsp.Checked = false;
            btnPSOne.Checked = false;
            LoadCapas();
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            frmConfig frm = new frmConfig();
            frm.ShowDialog();
        }

        private void btnPSOne_Click(object sender, EventArgs e)
        {
            btnPSOne.Checked = true;
            btnPsp.Checked = false;
            btnGba.Checked = false;
            LoadCapas();
        }

    }
}
