namespace PPE3_Udrive
{
    partial class FrmModifMagasin
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
            this.btnvalider = new System.Windows.Forms.Button();
            this.Jour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelferm = new System.Windows.Forms.Label();
            this.labelouvre = new System.Windows.Forms.Label();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdjoursemaine = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtville = new System.Windows.Forms.TextBox();
            this.txttel = new System.Windows.Forms.TextBox();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.txtmdp = new System.Windows.Forms.TextBox();
            this.txtcp = new System.Windows.Forms.TextBox();
            this.txtadr2 = new System.Windows.Forms.TextBox();
            this.txtadr1 = new System.Windows.Forms.TextBox();
            this.btnmodif = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRetour = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdjoursemaine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnvalider
            // 
            this.btnvalider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnvalider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvalider.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnvalider.Location = new System.Drawing.Point(345, 468);
            this.btnvalider.Margin = new System.Windows.Forms.Padding(2);
            this.btnvalider.Name = "btnvalider";
            this.btnvalider.Size = new System.Drawing.Size(317, 32);
            this.btnvalider.TabIndex = 11;
            this.btnvalider.Text = "Valider l\'horaire";
            this.btnvalider.UseVisualStyleBackColor = true;
            this.btnvalider.Click += new System.EventHandler(this.btnvalider_Click);
            // 
            // Jour
            // 
            this.Jour.HeaderText = "Jour";
            this.Jour.Name = "Jour";
            // 
            // labelferm
            // 
            this.labelferm.AutoSize = true;
            this.labelferm.Location = new System.Drawing.Point(520, 221);
            this.labelferm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelferm.Name = "labelferm";
            this.labelferm.Size = new System.Drawing.Size(151, 13);
            this.labelferm.TabIndex = 40;
            this.labelferm.Text = "Heure de fermeture de : Lundi ";
            // 
            // labelouvre
            // 
            this.labelouvre.AutoSize = true;
            this.labelouvre.Location = new System.Drawing.Point(342, 221);
            this.labelouvre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelouvre.Name = "labelouvre";
            this.labelouvre.Size = new System.Drawing.Size(142, 13);
            this.labelouvre.TabIndex = 39;
            this.labelouvre.Text = "Heure d\'ouverture de : Lundi";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Heure ouverture";
            this.Column2.Name = "Column2";
            // 
            // TimePicker2
            // 
            this.TimePicker2.Location = new System.Drawing.Point(523, 247);
            this.TimePicker2.Margin = new System.Windows.Forms.Padding(2);
            this.TimePicker2.Name = "TimePicker2";
            this.TimePicker2.Size = new System.Drawing.Size(139, 20);
            this.TimePicker2.TabIndex = 10;
            this.TimePicker2.Visible = false;
            // 
            // timePicker
            // 
            this.timePicker.Location = new System.Drawing.Point(345, 247);
            this.timePicker.Margin = new System.Windows.Forms.Padding(2);
            this.timePicker.Name = "timePicker";
            this.timePicker.Size = new System.Drawing.Size(139, 20);
            this.timePicker.TabIndex = 9;
            this.timePicker.Visible = false;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Heure fermeture";
            this.Column3.Name = "Column3";
            // 
            // grdjoursemaine
            // 
            this.grdjoursemaine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdjoursemaine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Jour,
            this.Column2,
            this.Column3});
            this.grdjoursemaine.Location = new System.Drawing.Point(345, 282);
            this.grdjoursemaine.Margin = new System.Windows.Forms.Padding(2);
            this.grdjoursemaine.Name = "grdjoursemaine";
            this.grdjoursemaine.RowTemplate.Height = 24;
            this.grdjoursemaine.Size = new System.Drawing.Size(317, 180);
            this.grdjoursemaine.TabIndex = 35;
            this.grdjoursemaine.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdjoursemaine_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 414);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Ville";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 368);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Numéro de téléphone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 221);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Nom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(142, 221);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Mot de passe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 368);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Code postal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 317);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Adresse 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 267);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Adresse 1";
            // 
            // txtville
            // 
            this.txtville.Location = new System.Drawing.Point(30, 429);
            this.txtville.Margin = new System.Windows.Forms.Padding(2);
            this.txtville.Name = "txtville";
            this.txtville.Size = new System.Drawing.Size(221, 20);
            this.txtville.TabIndex = 7;
            // 
            // txttel
            // 
            this.txttel.Location = new System.Drawing.Point(32, 383);
            this.txttel.Margin = new System.Windows.Forms.Padding(2);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(104, 20);
            this.txttel.TabIndex = 5;
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(30, 236);
            this.txtnom.Margin = new System.Windows.Forms.Padding(2);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(106, 20);
            this.txtnom.TabIndex = 1;
            // 
            // txtmdp
            // 
            this.txtmdp.Location = new System.Drawing.Point(145, 236);
            this.txtmdp.Margin = new System.Windows.Forms.Padding(2);
            this.txtmdp.Name = "txtmdp";
            this.txtmdp.Size = new System.Drawing.Size(106, 20);
            this.txtmdp.TabIndex = 2;
            // 
            // txtcp
            // 
            this.txtcp.Location = new System.Drawing.Point(145, 383);
            this.txtcp.Margin = new System.Windows.Forms.Padding(2);
            this.txtcp.Name = "txtcp";
            this.txtcp.Size = new System.Drawing.Size(106, 20);
            this.txtcp.TabIndex = 6;
            // 
            // txtadr2
            // 
            this.txtadr2.Location = new System.Drawing.Point(30, 332);
            this.txtadr2.Margin = new System.Windows.Forms.Padding(2);
            this.txtadr2.Name = "txtadr2";
            this.txtadr2.Size = new System.Drawing.Size(221, 20);
            this.txtadr2.TabIndex = 4;
            // 
            // txtadr1
            // 
            this.txtadr1.Location = new System.Drawing.Point(30, 282);
            this.txtadr1.Margin = new System.Windows.Forms.Padding(2);
            this.txtadr1.Name = "txtadr1";
            this.txtadr1.Size = new System.Drawing.Size(221, 20);
            this.txtadr1.TabIndex = 3;
            // 
            // btnmodif
            // 
            this.btnmodif.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmodif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmodif.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnmodif.Location = new System.Drawing.Point(30, 464);
            this.btnmodif.Name = "btnmodif";
            this.btnmodif.Size = new System.Drawing.Size(221, 36);
            this.btnmodif.TabIndex = 8;
            this.btnmodif.Text = "Appliquer les modifications";
            this.btnmodif.UseVisualStyleBackColor = true;
            this.btnmodif.Click += new System.EventHandler(this.btnmodif_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(27, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 16);
            this.label8.TabIndex = 44;
            this.label8.Text = "Modifier informations :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label9.Location = new System.Drawing.Point(232, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(199, 24);
            this.label9.TabIndex = 45;
            this.label9.Text = "Modifier un magasin";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(342, 194);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 16);
            this.label10.TabIndex = 44;
            this.label10.Text = "Modifier horaires :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PPE3_Udrive.Properties.Resources.LOGO;
            this.pictureBox1.Location = new System.Drawing.Point(194, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // btnRetour
            // 
            this.btnRetour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRetour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetour.ForeColor = System.Drawing.Color.Crimson;
            this.btnRetour.Location = new System.Drawing.Point(543, 526);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(119, 26);
            this.btnRetour.TabIndex = 12;
            this.btnRetour.Text = "Retourner au menu";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::PPE3_Udrive.Properties.Resources.GO_TO_MENU;
            this.pictureBox2.Location = new System.Drawing.Point(485, 499);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(88, 82);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 47;
            this.pictureBox2.TabStop = false;
            // 
            // FrmModifMagasin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 597);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnmodif);
            this.Controls.Add(this.btnvalider);
            this.Controls.Add(this.labelferm);
            this.Controls.Add(this.labelouvre);
            this.Controls.Add(this.TimePicker2);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.grdjoursemaine);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtville);
            this.Controls.Add(this.txttel);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.txtmdp);
            this.Controls.Add(this.txtcp);
            this.Controls.Add(this.txtadr2);
            this.Controls.Add(this.txtadr1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmModifMagasin";
            this.Text = "Modifier un magasin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmModifMagasin_FormClosed);
            this.Load += new System.EventHandler(this.FrmModifMagasin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdjoursemaine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnvalider;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jour;
        private System.Windows.Forms.Label labelferm;
        private System.Windows.Forms.Label labelouvre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DateTimePicker TimePicker2;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridView grdjoursemaine;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtville;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.TextBox txtmdp;
        private System.Windows.Forms.TextBox txtcp;
        private System.Windows.Forms.TextBox txtadr2;
        private System.Windows.Forms.TextBox txtadr1;
        private System.Windows.Forms.Button btnmodif;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}