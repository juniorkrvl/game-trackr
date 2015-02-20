using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameTrackr.View
{
    public partial class frmConfig : Form
    {
        public frmConfig()
        {
            InitializeComponent();
            this.Load += frmConfig_Load;
        }

        void frmConfig_Load(object sender, EventArgs e)
        {
            this.txtPSP.Text = Core.Configuration.config.GetPlatform(Model.Platform.Type.PSP).folder;
            this.txtGBA.Text = Core.Configuration.config.GetPlatform(Model.Platform.Type.GBA).folder;
            this.txtPSOne.Text = Core.Configuration.config.GetPlatform(Model.Platform.Type.PSOne).folder;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Core.Configuration.config.GetPlatform(Model.Platform.Type.PSP).folder = this.txtPSP.Text;
            Core.Configuration.config.GetPlatform(Model.Platform.Type.GBA).folder = this.txtGBA.Text;
            Core.Configuration.config.GetPlatform(Model.Platform.Type.PSOne).folder = this.txtPSOne.Text;

            Core.Configuration.SaveConfig();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPastaPSP_Click(object sender, EventArgs e)
        {
            fbDialog.ShowNewFolderButton = true;
            if (fbDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                txtPSP.Text = fbDialog.SelectedPath;
        }

        private void btnPastaPSO_Click(object sender, EventArgs e)
        {
            fbDialog.ShowNewFolderButton = true;
            if (fbDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                txtPSOne.Text = fbDialog.SelectedPath;
        }

        private void btnPastaGba_Click(object sender, EventArgs e)
        {
            fbDialog.ShowNewFolderButton = true;
            if (fbDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                txtGBA.Text = fbDialog.SelectedPath;
        }
    }
}
