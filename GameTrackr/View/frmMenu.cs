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

        public PictureBox selected = null;

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
                        //lblProcessando.Text = "Searching metadata: " + a.Name.Replace(a.Extension, "");
                        mudaProcessando_ muda = new mudaProcessando_(this.mudaProcessando);
                        muda("Searching metadata: " + a.Name.Replace(a.Extension, ""));

                        Game gm = p.games.Where(x => x.path == a.FullName).FirstOrDefault();

                        if (gm == null)
                        {
                            gm = Wrapper.GetGame(0, a.Name.Replace(a.Extension, ""), p.name);

                            if (gm == null)
                                gm = Wrapper.GetGame(0, Regex.Replace(a.Name.Replace(a.Extension, ""), @"[\d-]", string.Empty), p.name);

                            if (gm!= null)
                            {
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

                                p.games.Add(gm);
                            }
                               
                        }

                        if (pbProgresso.Value < pbProgresso.Maximum)
                            pbProgresso.Value += 1;

                    }

                }

            }

            Configuration.SaveConfig();
        }

        public delegate void mudaProcessando_(string text);

        public void mudaProcessando(string text) {
            if (this.InvokeRequired)
            {
                mudaProcessando_ d = new mudaProcessando_(mudaProcessando);
                this.Invoke(d, text);
            }
            else
            {
                this.lblProcessando.Text = text;
            }
            
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
                        pic.Tag = game.id;
                        pic.MouseEnter += pic_MouseEnter;

                        flContainer.Controls.Add(pic);

                    }
                }
            }

        }

        void pic_MouseEnter(object sender, EventArgs e)
        {
            if (selected != null && selected.Controls.Count > 0)
            {
                selected.Controls.Remove(selected.Controls[0]);
                Application.DoEvents();
            }

            selected = (PictureBox)sender;

            PictureBox pic = (PictureBox)sender;
            pic.BackgroundImage = GameTrackr.Properties.Resources.shadow_60;

            PictureBox edit = new PictureBox();
            edit.SizeMode = PictureBoxSizeMode.AutoSize;
            edit.Image = GameTrackr.Properties.Resources.edit_quadrado;

            PictureBox pic2 = new PictureBox();
            pic2.Tag = pic.Tag;
            pic2.Size = pic.Size;
            pic2.BackgroundImage = GameTrackr.Properties.Resources.shadow_60;
            pic2.BackColor = Color.Transparent;
            pic2.Cursor = Cursors.Hand;
            toolTip.SetToolTip(pic2, "Editar Jogo");
            toolTip.SetToolTip(edit, "Editar Jogo");

            edit.Top = (pic2.Height / 2) - (edit.Height / 2);
            edit.Left = (pic2.Width / 2) - (edit.Width / 2);

            pic2.Controls.Add(edit);

            pic.Controls.Add(pic2);

            pic2.MouseLeave += pic2_MouseLeave;
            pic2.Click += pic2_Click;
        }

        void pic2_Click(object sender, EventArgs e)
        {
            frmEditar frm = new frmEditar((int)(sender as PictureBox).Tag);
            frm.Show();
        }

        void pic2_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            PictureBox parent = pic.Parent as PictureBox;
            parent.Controls.Remove(pic);
        }


        private void btnPsp_Click(object sender, EventArgs e)
        {
            btnPsp.Checked = true;
            btnGba.Checked = false;
            btnPSOne.Checked = false;
            LoadCapas();

            if (btnPsp.Checked && flContainer.Controls.Count == 0)
            {
                bgWorker.RunWorkerAsync();
            }
        }

        private void btnGba_Click(object sender, EventArgs e)
        {
            btnGba.Checked = true;
            btnPsp.Checked = false;
            btnPSOne.Checked = false;
            LoadCapas();

            if (btnGba.Checked && flContainer.Controls.Count == 0)
            {
                bgWorker.RunWorkerAsync();
            }
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

            if (btnPSOne.Checked && flContainer.Controls.Count == 0)
            {
                bgWorker.RunWorkerAsync();
            }
        }

    }
}
