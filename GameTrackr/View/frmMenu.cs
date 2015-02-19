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

namespace GameTrackr.View
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnAddBiblioteca_Click(object sender, EventArgs e)
        {

            flContainer.Controls.Clear();

            DirectoryInfo dirInfo = new DirectoryInfo(@"C:\Teste");
            FileInfo[] fileNames = dirInfo.GetFiles("*.*");

            //string[] arquivos = System.IO.Directory.GetFiles(@"C:\Teste");

            foreach (FileInfo a in fileNames)
            {

                Game gm = Wrapper.GetGame(0, a.Name.Replace(a.Extension, ""), "Sony PSP");

                if (gm == null)
                    gm = Wrapper.GetGame(0, Regex.Replace(a.Name.Replace(a.Extension, ""), @"[\d-]", string.Empty), "Sony PSP");
                

                if (gm != null)
                {
                    PictureBox pic = new PictureBox();
                    pic.Width = 121;
                    pic.Height = 209;

                    GameImage gi = gm.GetFrontBox();
                    if (gi != null)
                        pic.Load(gi.original);

                    pic.SizeMode = PictureBoxSizeMode.StretchImage;

                    flContainer.Controls.Add(pic);
                    Application.DoEvents();
                }

                //List<Game> list = Wrapper.GetGames(a.Name.Replace(a.Extension, ""), "Sony PSP");

                //foreach (Game gm in list)
                //{
                //    gm.GetInfo();

                //    PictureBox pic = new PictureBox();
                //    pic.Width = 100;
                //    pic.Height = 173;
                //    pic.Load(gm.GetFrontBox().original);
                //    pic.SizeMode = PictureBoxSizeMode.StretchImage;

                //    flContainer.Controls.Add(pic);
                //}

            }

        }

        private void btnPsp_Click(object sender, EventArgs e)
        {
            btnPsp.Checked = true;
            btnGba.Checked = false;
        }

        private void btnGba_Click(object sender, EventArgs e)
        {
            btnGba.Checked = true;
            btnPsp.Checked = false;
        }

    }
}
