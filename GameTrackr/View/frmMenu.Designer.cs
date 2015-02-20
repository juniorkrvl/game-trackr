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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.mnMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.flContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnConfig = new System.Windows.Forms.ToolStripButton();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.btnPsp = new System.Windows.Forms.ToolStripButton();
            this.btnPSOne = new System.Windows.Forms.ToolStripButton();
            this.btnGba = new System.Windows.Forms.ToolStripButton();
            this.pbProgresso = new System.Windows.Forms.ToolStripProgressBar();
            this.lblProcessando = new System.Windows.Forms.ToolStripLabel();
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.mnMenu.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnMenu
            // 
            this.mnMenu.BackColor = System.Drawing.Color.DimGray;
            this.mnMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.mnMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnConfig,
            this.btnRefresh,
            this.toolStripSeparator1,
            this.btnPsp,
            this.btnPSOne,
            this.btnGba});
            this.mnMenu.Location = new System.Drawing.Point(0, 0);
            this.mnMenu.Name = "mnMenu";
            this.mnMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mnMenu.Size = new System.Drawing.Size(704, 54);
            this.mnMenu.TabIndex = 0;
            this.mnMenu.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.White;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 54);
            // 
            // flContainer
            // 
            this.flContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flContainer.AutoScroll = true;
            this.flContainer.Location = new System.Drawing.Point(0, 54);
            this.flContainer.Name = "flContainer";
            this.flContainer.Size = new System.Drawing.Size(704, 359);
            this.flContainer.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pbProgresso,
            this.lblProcessando});
            this.toolStrip1.Location = new System.Drawing.Point(0, 413);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(704, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnConfig
            // 
            this.btnConfig.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnConfig.ForeColor = System.Drawing.Color.White;
            this.btnConfig.Image = global::GameTrackr.Properties.Resources.setting_tools;
            this.btnConfig.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnConfig.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(88, 51);
            this.btnConfig.Text = "Configurações";
            this.btnConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Image = global::GameTrackr.Properties.Resources.arrow_refresh1;
            this.btnRefresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(57, 51);
            this.btnRefresh.Text = "Atualizar";
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRefresh.Click += new System.EventHandler(this.btnAddBiblioteca_Click);
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
            this.btnPsp.Tag = "Sony PSP";
            this.btnPsp.Text = "Playstation Portable";
            this.btnPsp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPsp.Click += new System.EventHandler(this.btnPsp_Click);
            // 
            // btnPSOne
            // 
            this.btnPSOne.ForeColor = System.Drawing.Color.White;
            this.btnPSOne.Image = global::GameTrackr.Properties.Resources.sony_psone_icon;
            this.btnPSOne.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPSOne.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPSOne.Name = "btnPSOne";
            this.btnPSOne.Size = new System.Drawing.Size(94, 51);
            this.btnPSOne.Tag = "Sony Playstation";
            this.btnPSOne.Text = "Playstation One";
            this.btnPSOne.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPSOne.Click += new System.EventHandler(this.btnPSOne_Click);
            // 
            // btnGba
            // 
            this.btnGba.ForeColor = System.Drawing.Color.White;
            this.btnGba.Image = global::GameTrackr.Properties.Resources.nintendo_game_boy_advance_icon;
            this.btnGba.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnGba.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGba.Name = "btnGba";
            this.btnGba.Size = new System.Drawing.Size(114, 51);
            this.btnGba.Tag = "Nintendo Game Boy Advance";
            this.btnGba.Text = "Game Boy Advance";
            this.btnGba.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGba.Click += new System.EventHandler(this.btnGba_Click);
            // 
            // pbProgresso
            // 
            this.pbProgresso.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.pbProgresso.Name = "pbProgresso";
            this.pbProgresso.Size = new System.Drawing.Size(100, 22);
            // 
            // lblProcessando
            // 
            this.lblProcessando.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblProcessando.BackColor = System.Drawing.Color.Transparent;
            this.lblProcessando.Name = "lblProcessando";
            this.lblProcessando.Size = new System.Drawing.Size(74, 22);
            this.lblProcessando.Text = "Processando";
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.FlowLayoutPanel flContainer;
        private System.Windows.Forms.ToolStripButton btnGba;
        private System.Windows.Forms.ToolStripButton btnPsp;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnConfig;
        private System.Windows.Forms.ToolStripButton btnPSOne;
        private System.Windows.Forms.ToolStripProgressBar pbProgresso;
        private System.Windows.Forms.ToolStripLabel lblProcessando;
        private System.ComponentModel.BackgroundWorker bgWorker;
    }
}