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
    public partial class frmEditar : Form
    {

        private int id { get; set; }

        public frmEditar(int id)
        {
            InitializeComponent();
            this.Load += frmEditar_Load;
            this.id = id;
        }

        void frmEditar_Load(object sender, EventArgs e)
        {
            if (this.id > 0)
            {
                Model.Game gm = Core.Configuration.config.GetGame(this.id);
                pictureBox1.Image = gm.cover;
                txtTitulo.Text = gm.name;
                txtDescricao.Text = gm.overview;
                txtCoop.Text = gm.coop;
            }
        }
    }
}
