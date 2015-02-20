namespace GameTrackr.View
{
    partial class frmConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfig));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPastaPSP = new System.Windows.Forms.Button();
            this.txtPSP = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnPastaPSO = new System.Windows.Forms.Button();
            this.txtPSOne = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnPastaGba = new System.Windows.Forms.Button();
            this.txtGBA = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.fbDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnPastaPSP);
            this.groupBox1.Controls.Add(this.txtPSP);
            this.groupBox1.Location = new System.Drawing.Point(6, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 60);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pasta de roms PSP";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GameTrackr.Properties.Resources.sony_psp_icon;
            this.pictureBox1.Location = new System.Drawing.Point(9, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnPastaPSP
            // 
            this.btnPastaPSP.Location = new System.Drawing.Point(483, 21);
            this.btnPastaPSP.Name = "btnPastaPSP";
            this.btnPastaPSP.Size = new System.Drawing.Size(42, 26);
            this.btnPastaPSP.TabIndex = 7;
            this.btnPastaPSP.Text = "...";
            this.btnPastaPSP.UseVisualStyleBackColor = true;
            this.btnPastaPSP.Click += new System.EventHandler(this.btnPastaPSP_Click);
            // 
            // txtPSP
            // 
            this.txtPSP.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPSP.Location = new System.Drawing.Point(47, 22);
            this.txtPSP.Name = "txtPSP";
            this.txtPSP.Size = new System.Drawing.Size(430, 26);
            this.txtPSP.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.btnPastaPSO);
            this.groupBox2.Controls.Add(this.txtPSOne);
            this.groupBox2.Location = new System.Drawing.Point(6, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(551, 60);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pasta de roms PS One";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GameTrackr.Properties.Resources.sony_psone_icon;
            this.pictureBox2.Location = new System.Drawing.Point(9, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // btnPastaPSO
            // 
            this.btnPastaPSO.Location = new System.Drawing.Point(483, 21);
            this.btnPastaPSO.Name = "btnPastaPSO";
            this.btnPastaPSO.Size = new System.Drawing.Size(42, 26);
            this.btnPastaPSO.TabIndex = 7;
            this.btnPastaPSO.Text = "...";
            this.btnPastaPSO.UseVisualStyleBackColor = true;
            this.btnPastaPSO.Click += new System.EventHandler(this.btnPastaPSO_Click);
            // 
            // txtPSOne
            // 
            this.txtPSOne.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPSOne.Location = new System.Drawing.Point(47, 22);
            this.txtPSOne.Name = "txtPSOne";
            this.txtPSOne.Size = new System.Drawing.Size(430, 26);
            this.txtPSOne.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureBox3);
            this.groupBox3.Controls.Add(this.btnPastaGba);
            this.groupBox3.Controls.Add(this.txtGBA);
            this.groupBox3.Location = new System.Drawing.Point(6, 137);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(551, 60);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pasta de roms GBA";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::GameTrackr.Properties.Resources.nintendo_game_boy_advance_icon;
            this.pictureBox3.Location = new System.Drawing.Point(9, 19);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // btnPastaGba
            // 
            this.btnPastaGba.Location = new System.Drawing.Point(483, 21);
            this.btnPastaGba.Name = "btnPastaGba";
            this.btnPastaGba.Size = new System.Drawing.Size(42, 26);
            this.btnPastaGba.TabIndex = 7;
            this.btnPastaGba.Text = "...";
            this.btnPastaGba.UseVisualStyleBackColor = true;
            this.btnPastaGba.Click += new System.EventHandler(this.btnPastaGba_Click);
            // 
            // txtGBA
            // 
            this.txtGBA.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGBA.Location = new System.Drawing.Point(47, 22);
            this.txtGBA.Name = "txtGBA";
            this.txtGBA.Size = new System.Drawing.Size(430, 26);
            this.txtGBA.TabIndex = 5;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(455, 203);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(102, 35);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(347, 203);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(102, 35);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 248);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConfig";
            this.Text = "Configurações";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPastaPSP;
        private System.Windows.Forms.TextBox txtPSP;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnPastaPSO;
        private System.Windows.Forms.TextBox txtPSOne;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnPastaGba;
        private System.Windows.Forms.TextBox txtGBA;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.FolderBrowserDialog fbDialog;
    }
}