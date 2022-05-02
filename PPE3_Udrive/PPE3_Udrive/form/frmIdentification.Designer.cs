namespace PPE3_Udrive
{
    partial class identification
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.txtmdp = new System.Windows.Forms.TextBox();
            this.btnconnection = new System.Windows.Forms.Button();
            this.cboMagasin = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 320);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mot de passe";
            // 
            // txtmdp
            // 
            this.txtmdp.Location = new System.Drawing.Point(77, 335);
            this.txtmdp.Margin = new System.Windows.Forms.Padding(2);
            this.txtmdp.Name = "txtmdp";
            this.txtmdp.Size = new System.Drawing.Size(218, 20);
            this.txtmdp.TabIndex = 2;
            this.txtmdp.UseSystemPasswordChar = true;
            this.txtmdp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmdp_KeyPress);
            // 
            // btnconnection
            // 
            this.btnconnection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnconnection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnconnection.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnconnection.Location = new System.Drawing.Point(102, 454);
            this.btnconnection.Margin = new System.Windows.Forms.Padding(2);
            this.btnconnection.Name = "btnconnection";
            this.btnconnection.Size = new System.Drawing.Size(267, 32);
            this.btnconnection.TabIndex = 3;
            this.btnconnection.Text = "Se connecter";
            this.btnconnection.UseVisualStyleBackColor = true;
            this.btnconnection.Click += new System.EventHandler(this.btnconnection_Click);
            // 
            // cboMagasin
            // 
            this.cboMagasin.FormattingEnabled = true;
            this.cboMagasin.Location = new System.Drawing.Point(77, 269);
            this.cboMagasin.Margin = new System.Windows.Forms.Padding(2);
            this.cboMagasin.Name = "cboMagasin";
            this.cboMagasin.Size = new System.Drawing.Size(218, 21);
            this.cboMagasin.TabIndex = 1;
            this.cboMagasin.Text = "Votre magasin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 254);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Magasin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(105, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Identification";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PPE3_Udrive.Properties.Resources.LOGO;
            this.pictureBox1.Location = new System.Drawing.Point(28, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PPE3_Udrive.Properties.Resources.username;
            this.pictureBox2.Location = new System.Drawing.Point(28, 252);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::PPE3_Udrive.Properties.Resources.password;
            this.pictureBox3.Location = new System.Drawing.Point(28, 308);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(47, 49);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnconnection);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-74, -54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 626);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Location = new System.Drawing.Point(102, 263);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 5);
            this.panel2.TabIndex = 4;
            // 
            // identification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(332, 456);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboMagasin);
            this.Controls.Add(this.txtmdp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "identification";
            this.Text = "Identification";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.identification_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmdp;
        private System.Windows.Forms.Button btnconnection;
        private System.Windows.Forms.ComboBox cboMagasin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

