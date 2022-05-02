namespace PPE3_Udrive
{
    partial class frmCommande
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
            this.txtnumMag = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboNonLOuiP = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboOuiLOuiP = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRetrait = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPreparee = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtClinum = new System.Windows.Forms.Label();
            this.grdCommander1 = new System.Windows.Forms.DataGridView();
            this.CodePdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantité = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.cboNonLNonP = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnRetour = new System.Windows.Forms.Button();
            this.btnlivre = new System.Windows.Forms.Button();
            this.btnprepare = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdCommander1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtnumMag
            // 
            this.txtnumMag.AutoSize = true;
            this.txtnumMag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumMag.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtnumMag.Location = new System.Drawing.Point(631, 161);
            this.txtnumMag.Name = "txtnumMag";
            this.txtnumMag.Size = new System.Drawing.Size(16, 16);
            this.txtnumMag.TabIndex = 1;
            this.txtnumMag.Text = "  ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(385, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vous êtes connecté au magasin : ";
            // 
            // cboNonLOuiP
            // 
            this.cboNonLOuiP.FormattingEnabled = true;
            this.cboNonLOuiP.Location = new System.Drawing.Point(531, 224);
            this.cboNonLOuiP.Name = "cboNonLOuiP";
            this.cboNonLOuiP.Size = new System.Drawing.Size(53, 21);
            this.cboNonLOuiP.TabIndex = 3;
            this.cboNonLOuiP.SelectedIndexChanged += new System.EventHandler(this.cboCommandeNonPrete_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Commandes non livrées et préparées : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(650, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Commandes livrées : ";
            // 
            // cboOuiLOuiP
            // 
            this.cboOuiLOuiP.FormattingEnabled = true;
            this.cboOuiLOuiP.Location = new System.Drawing.Point(758, 224);
            this.cboOuiLOuiP.Name = "cboOuiLOuiP";
            this.cboOuiLOuiP.Size = new System.Drawing.Size(53, 21);
            this.cboOuiLOuiP.TabIndex = 3;
            this.cboOuiLOuiP.SelectedIndexChanged += new System.EventHandler(this.cboCommandeLivree_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(12, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Informations sur la commande :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Numéro : ";
            // 
            // txtNum
            // 
            this.txtNum.AutoSize = true;
            this.txtNum.Location = new System.Drawing.Point(71, 306);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(12, 13);
            this.txtNum.TabIndex = 4;
            this.txtNum.Text = "/";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 329);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Date de commande : ";
            // 
            // txtDate
            // 
            this.txtDate.AutoSize = true;
            this.txtDate.Location = new System.Drawing.Point(127, 329);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(12, 13);
            this.txtDate.TabIndex = 4;
            this.txtDate.Text = "/";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 351);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Date de retrait : ";
            // 
            // txtRetrait
            // 
            this.txtRetrait.AutoSize = true;
            this.txtRetrait.Location = new System.Drawing.Point(101, 351);
            this.txtRetrait.Name = "txtRetrait";
            this.txtRetrait.Size = new System.Drawing.Size(12, 13);
            this.txtRetrait.TabIndex = 4;
            this.txtRetrait.Text = "/";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 374);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Préparée :";
            // 
            // txtPreparee
            // 
            this.txtPreparee.AutoSize = true;
            this.txtPreparee.Location = new System.Drawing.Point(77, 374);
            this.txtPreparee.Name = "txtPreparee";
            this.txtPreparee.Size = new System.Drawing.Size(12, 13);
            this.txtPreparee.TabIndex = 5;
            this.txtPreparee.Text = "/";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 396);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Numéro de client :";
            // 
            // txtClinum
            // 
            this.txtClinum.AutoSize = true;
            this.txtClinum.Location = new System.Drawing.Point(111, 396);
            this.txtClinum.Name = "txtClinum";
            this.txtClinum.Size = new System.Drawing.Size(12, 13);
            this.txtClinum.TabIndex = 5;
            this.txtClinum.Text = "/";
            // 
            // grdCommander1
            // 
            this.grdCommander1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCommander1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodePdt,
            this.Produit,
            this.Column1,
            this.Quantité});
            this.grdCommander1.Location = new System.Drawing.Point(15, 464);
            this.grdCommander1.Name = "grdCommander1";
            this.grdCommander1.Size = new System.Drawing.Size(837, 320);
            this.grdCommander1.TabIndex = 6;
            // 
            // CodePdt
            // 
            this.CodePdt.HeaderText = "Code pdt";
            this.CodePdt.Name = "CodePdt";
            // 
            // Produit
            // 
            this.Produit.HeaderText = "Produit";
            this.Produit.Name = "Produit";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Prix Unitaire";
            this.Column1.Name = "Column1";
            // 
            // Quantité
            // 
            this.Quantité.HeaderText = "Quantité";
            this.Quantité.Name = "Quantité";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label11.Location = new System.Drawing.Point(12, 437);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(179, 15);
            this.label11.TabIndex = 2;
            this.label11.Text = "Contenu de la commande :";
            // 
            // cboNonLNonP
            // 
            this.cboNonLNonP.FormattingEnabled = true;
            this.cboNonLNonP.Location = new System.Drawing.Point(229, 224);
            this.cboNonLNonP.Name = "cboNonLNonP";
            this.cboNonLNonP.Size = new System.Drawing.Size(53, 21);
            this.cboNonLNonP.TabIndex = 8;
            this.cboNonLNonP.SelectedIndexChanged += new System.EventHandler(this.cboNonLNonP_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 227);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(211, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "Commandes non livrées et non préparées : ";
            // 
            // btnRetour
            // 
            this.btnRetour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetour.ForeColor = System.Drawing.Color.Crimson;
            this.btnRetour.Location = new System.Drawing.Point(1030, 758);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(119, 26);
            this.btnRetour.TabIndex = 45;
            this.btnRetour.Text = "Retourner au menu";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // btnlivre
            // 
            this.btnlivre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlivre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlivre.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnlivre.Location = new System.Drawing.Point(936, 513);
            this.btnlivre.Name = "btnlivre";
            this.btnlivre.Size = new System.Drawing.Size(135, 43);
            this.btnlivre.TabIndex = 46;
            this.btnlivre.Text = "Commande livrée";
            this.btnlivre.UseVisualStyleBackColor = true;
            this.btnlivre.Click += new System.EventHandler(this.btnlivre_Click);
            // 
            // btnprepare
            // 
            this.btnprepare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnprepare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprepare.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnprepare.Location = new System.Drawing.Point(936, 464);
            this.btnprepare.Name = "btnprepare";
            this.btnprepare.Size = new System.Drawing.Size(135, 43);
            this.btnprepare.TabIndex = 47;
            this.btnprepare.Text = "Commande préparée";
            this.btnprepare.UseVisualStyleBackColor = true;
            this.btnprepare.Click += new System.EventHandler(this.btnprepare_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PPE3_Udrive.Properties.Resources.LOGO;
            this.pictureBox1.Location = new System.Drawing.Point(388, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(377, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 24);
            this.label1.TabIndex = 48;
            this.label1.Text = "Visualisation des commandes";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label13.Location = new System.Drawing.Point(12, 198);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(205, 15);
            this.label13.TabIndex = 50;
            this.label13.Text = "Sélectionnez une commande : ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label14.Location = new System.Drawing.Point(900, 437);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(205, 15);
            this.label14.TabIndex = 2;
            this.label14.Text = "Modification de la commande :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(15, 258);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(837, 5);
            this.panel1.TabIndex = 51;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(837, 5);
            this.panel2.TabIndex = 52;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.panel3.Location = new System.Drawing.Point(15, 424);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(837, 5);
            this.panel3.TabIndex = 52;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::PPE3_Udrive.Properties.Resources.GO_TO_MENU;
            this.pictureBox2.Location = new System.Drawing.Point(972, 730);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(88, 82);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 53;
            this.pictureBox2.TabStop = false;
            // 
            // frmCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1161, 796);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnprepare);
            this.Controls.Add(this.btnlivre);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.cboNonLNonP);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.grdCommander1);
            this.Controls.Add(this.txtPreparee);
            this.Controls.Add(this.txtClinum);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.txtRetrait);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboOuiLOuiP);
            this.Controls.Add(this.cboNonLOuiP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnumMag);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmCommande";
            this.Text = "Visualiser les commandes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCommande_FormClosed);
            this.Load += new System.EventHandler(this.frmCommande_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdCommander1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtnumMag;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboNonLOuiP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboOuiLOuiP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label txtNum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label txtDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label txtRetrait;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label txtPreparee;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label txtClinum;
        private System.Windows.Forms.DataGridView grdCommander1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodePdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantité;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboNonLNonP;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Button btnlivre;
        private System.Windows.Forms.Button btnprepare;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}