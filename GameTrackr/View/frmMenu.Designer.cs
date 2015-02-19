namespace GameTrackr.View
{
    partial class frmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnMenu = new System.Windows.Forms.ToolStrip();
            this.btnAddBiblioteca = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPsp = new System.Windows.Forms.ToolStripButton();
            this.btnGba = new System.Windows.Forms.ToolStripButton();
            this.flContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAddManual = new System.Windows.Forms.ToolStripButton();
            this.btnAtualizar = new System.Windows.Forms.ToolStripButton();
            this.mnMenu.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnMenu
            // 
            this.mnMenu.BackColor = System.Drawing.Color.DimGray;
            this.mnMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.mnMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddBiblioteca,
            this.toolStripSeparator1,
            this.btnPsp,
            this.btnGba});
            this.mnMenu.Location = new System.Drawing.Point(0, 0);
            this.mnMenu.Name = "mnMenu";
            this.mnMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mnMenu.Size = new System.Drawing.Size(704, 54);
            this.mnMenu.TabIndex = 0;
            this.mnMenu.Text = "toolStrip1";
            // 
            // btnAddBiblioteca
            // 
            this.btnAddBiblioteca.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnAddBiblioteca.ForeColor = System.Drawing.Color.White;
            this.btnAddBiblioteca.Image = global::GameTrackr.Properties.Resources.book_add;
            this.btnAddBiblioteca.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAddBiblioteca.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddBiblioteca.Name = "btnAddBiblioteca";
            this.btnAddBiblioteca.Size = new System.Drawing.Size(94, 51);
            this.btnAddBiblioteca.Text = "Nova Biblioteca";
            this.btnAddBiblioteca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddBiblioteca.Click += new System.EventHandler(this.btnAddBiblioteca_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.White;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 54);
            // 
            // btnPsp
            // 
            this.btnPsp.Checked = true;
            this.btnPsp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btnPsp.ForeColor = System.Drawing.Color.White;
            this.btnPsp.Image = global::GameTrackr.Properties.Resources.sony_psp_icon;
            this.btnPsp.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPsp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPsp.Name = "btnPsp";
            this.btnPsp.Size = new System.Drawing.Size(116, 51);
            this.btnPsp.Text = "Playstation Portable";
            this.btnPsp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPsp.Click += new System.EventHandler(this.btnPsp_Click);
            // 
            // btnGba
            // 
            this.btnGba.ForeColor = System.Drawing.Color.White;
            this.btnGba.Image = global::GameTrackr.Properties.Resources.gba_icon;
            this.btnGba.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnGba.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGba.Name = "btnGba";
            this.btnGba.Size = new System.Drawing.Size(114, 51);
            this.btnGba.Text = "Game Boy Advance";
            this.btnGba.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGba.Click += new System.EventHandler(this.btnGba_Click);
            // 
            // flContainer
            // 
            this.flContainer.AutoScroll = true;
            this.flContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flContainer.Location = new System.Drawing.Point(0, 54);
            this.flContainer.Name = "flContainer";
            this.flContainer.Size = new System.Drawing.Size(704, 384);
            this.flContainer.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddManual,
            this.btnAtualizar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 413);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(704, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAddManual
            // 
            this.btnAddManual.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddManual.Image = global::GameTrackr.Properties.Resources.controller_add;
            this.btnAddManual.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddManual.Name = "btnAddManual";
            this.btnAddManual.Size = new System.Drawing.Size(23, 22);
            this.btnAddManual.Text = "Adicionar à biblioteca";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAtualizar.Image = global::GameTrackr.Properties.Resources.arrow_refresh;
            this.btnAtualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(23, 22);
            this.btnAtualizar.Text = "Atualizar";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(704, 438);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.flContainer);
            this.Controls.Add(this.mnMenu);
            this.Name = "frmMenu";
            this.Text = "Game Trackr";
            this.mnMenu.ResumeLayout(false);
            this.mnMenu.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip mnMenu;
        private System.Windows.Forms.ToolStripButton btnAddBiblioteca;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.FlowLayoutPanel flContainer;
        private System.Windows.Forms.ToolStripButton btnGba;
        private System.Windows.Forms.ToolStripButton btnPsp;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAddManual;
        private System.Windows.Forms.ToolStripButton btnAtualizar;
    }
}