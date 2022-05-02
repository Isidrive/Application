using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PPE3_Udrive
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnModifMag_Click(object sender, EventArgs e)
        {
            Form frmModifMagasin = new FrmModifMagasin();
            frmModifMagasin.Show();
            this.Hide();
        }

        private void btnAjoutProduit_Click(object sender, EventArgs e)
        {
            Form frmAjoutProduit = new frmAjoutProduit();
            frmAjoutProduit.Show();
            this.Hide();
        }

        private void btnCommande_Click(object sender, EventArgs e)
        {
            Form frmCommande = new frmCommande();
            frmCommande.Show();
            this.Hide();
        }

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            Form frmIdentification = new identification();
            frmIdentification.Show();
            this.Hide();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Voulez-vous vraiment fermer l'application ?", "Avertissement", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialog == DialogResult.No)
            {
                //Rester sur menu
            }
        }


        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void frmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
