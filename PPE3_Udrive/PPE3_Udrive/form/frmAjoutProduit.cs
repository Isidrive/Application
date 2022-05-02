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
    public partial class frmAjoutProduit : Form
    {
        int lesounum;
        public frmAjoutProduit()
        {
            InitializeComponent();
        }

        private void frmAjoutProduit_Load(object sender, EventArgs e)
        {
            PasserelleCategorie.chargementCateg();
            for (int i = 0; i < varglobale.lesCategories.Count(); i++)
            {
                cboCateg.Items.Add(varglobale.lesCategories[i].getLib());
            }
            cboCateg.SelectedIndex = 0;
        }

        private void cboCateg_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboSouCat.Items.Clear();
            int lacateg = cboCateg.SelectedIndex+1;
            PasserelleSoucat.chargementSouCateg(lacateg);
            for (int i = 0; i < varglobale.lesSousCategories.Count(); i++)
            {
                cboSouCat.Items.Add(varglobale.lesSousCategories[i].getLib());
            }
        }

        private void cboSouCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            string lelib = Convert.ToString(cboSouCat.SelectedItem);
            lesounum = PasserelleSoucat.numSoucat(lelib);
        }

        private void btnCreer_Click(object sender, EventArgs e)
        {
            Single singleValue;
            int intValue;
            //Check si tous les éléments sont indiqués
            if (String.IsNullOrWhiteSpace(txtLib.Text) || String.IsNullOrWhiteSpace(txtPrix.Text) || String.IsNullOrWhiteSpace(txtStock.Text) || cboSouCat.SelectedItem == null)
            {
                MessageBox.Show("Veuillez remplir tout les champs");
            }
            //Si tous les éléments sont indiqués                
            else
            {
                // Check txtprix = Single
                if (!Single.TryParse(txtPrix.Text, out singleValue))
                {
                    MessageBox.Show("Veuillez entrer un prix correcte");
                    txtPrix.BackColor = Color.OrangeRed;
                }
                else
                {
                    //Check txtstock = int
                    if (!int.TryParse(txtStock.Text, out intValue))
                    {
                        MessageBox.Show("Veuillez entrer un stock correcte");
                        txtStock.BackColor = Color.OrangeRed;
                    }
                    //Ajoute produit
                    else
                    {
                        PasserelleProduit.ajoutproduit(txtLib.Text, Convert.ToSingle(txtPrix.Text), lesounum);
                        Produit unproduit = PasserelleProduit.dernierproduit();
                        PasserelleStock.ajouterproduitStock(varglobale.unMagasin, unproduit, Convert.ToInt32(txtStock.Text));
                        MessageBox.Show("Vous avez ajouté le produit " + txtLib.Text + " au prix de " + txtPrix.Text + "€ dans la catégorie " + cboCateg.SelectedItem + " et dans la sous-catégorie " + cboSouCat.SelectedItem + " avec un stock de " + txtStock.Text);
                        txtLib.Clear();
                        txtPrix.Clear();
                        txtStock.Clear();
                        txtPrix.BackColor = Color.White;
                        txtStock.BackColor = Color.White;
                        cboCateg.SelectedIndex = 0;
                        cboSouCat.SelectedIndex = 0;
                    }

                }
            }    
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            Form frmMenu = new frmMenu();
            frmMenu.Show();
            this.Hide();
        }

        private void frmAjoutProduit_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
 
    }
}
