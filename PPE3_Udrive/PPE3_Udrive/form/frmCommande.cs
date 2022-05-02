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
    public partial class frmCommande : Form
    {
        List<Commande> NonPNonL = new List<Commande>();
        List<Commande> OuiPNonL = new List<Commande>();
        List<Commande> OuiPOuiL = new List<Commande>();
        public frmCommande()
        {
            InitializeComponent();
            
        }

        private void frmCommande_Load(object sender, EventArgs e)
        {

            cboNonLNonP.Items.Clear();
            cboNonLOuiP.Items.Clear();
            cboOuiLOuiP.Items.Clear();
            // Initialise la liste varglobale de commande
            PasserelleCommande.afficherCommande();

            // Initialise les listes
            
            NonPNonL = varglobale.unMagasin.CommandeNonPnonL(varglobale.lesCommandes);
            OuiPNonL = varglobale.unMagasin.CommandeOuiPnonL(varglobale.lesCommandes);
            OuiPOuiL = varglobale.unMagasin.CommandeOuiPOuiL(varglobale.lesCommandes);

            // affichage des commandes grâce aux méthodes au dessus
            for(int i = 0;i<NonPNonL.Count();i++)
            {
                cboNonLNonP.Items.Add(Convert.ToString(NonPNonL[i].getcomnum()));
            }
            for (int i = 0; i < OuiPNonL.Count(); i++)
            {
                cboNonLOuiP.Items.Add(Convert.ToString(OuiPNonL[i].getcomnum()));
            }
            for (int i = 0; i < OuiPOuiL.Count(); i++)
            {
                cboOuiLOuiP.Items.Add(Convert.ToString(OuiPOuiL[i].getcomnum()));
            }
        }


        // Non L oui P
        private void cboCommandeNonPrete_SelectedIndexChanged(object sender, EventArgs e)
        {
             Commande laCommande = OuiPNonL[cboNonLOuiP.SelectedIndex];
            txtNum.Text = Convert.ToString(laCommande.getcomnum());
            txtDate.Text = Convert.ToString(laCommande.getcomdateh());
            txtRetrait.Text = Convert.ToString(laCommande.getcomdatehretrait());
            txtPreparee.Text = "Oui";           
            txtClinum.Text = Convert.ToString(laCommande.getclient().getclinum());
            //Infos table commander grd
            grdCommander1.Rows.Clear();
            PasserelleCommander.afficherCommander(laCommande.getcomnum());
            for (int i = 0; i < varglobale.lesCommander.Count(); i++)
            {
                grdCommander1.Rows.Add(varglobale.lesCommander[i].getpronum(), varglobale.lesProduits[i].getlib(), varglobale.lesProduits[i].getprix() + " €", varglobale.lesCommander[i].getquantite());
            }
        }
            


        

        //Oui L Oui P
        private void cboCommandeLivree_SelectedIndexChanged(object sender, EventArgs e)
        {
             Commande laCommande = OuiPOuiL[cboOuiLOuiP.SelectedIndex];
            txtNum.Text = Convert.ToString(laCommande.getcomnum());
            txtDate.Text = Convert.ToString(laCommande.getcomdateh());
            txtRetrait.Text = Convert.ToString(laCommande.getcomdatehretrait());
            txtPreparee.Text = "Oui";           
            txtClinum.Text = Convert.ToString(laCommande.getclient().getclinum());
            //Infos table commander grd
            grdCommander1.Rows.Clear();
            PasserelleCommander.afficherCommander(laCommande.getcomnum());
            for (int i = 0; i < varglobale.lesCommander.Count(); i++)
            {
                grdCommander1.Rows.Add(varglobale.lesCommander[i].getpronum(), varglobale.lesProduits[i].getlib(), varglobale.lesProduits[i].getprix() + " €", varglobale.lesCommander[i].getquantite());
            }
        
        }

        //Non L non P
        private void cboNonLNonP_SelectedIndexChanged(object sender, EventArgs e)
        {

            Commande laCommande = NonPNonL[cboNonLNonP.SelectedIndex];
            txtNum.Text = Convert.ToString(laCommande.getcomnum());
            txtDate.Text = Convert.ToString(laCommande.getcomdateh());
            txtRetrait.Text = Convert.ToString(laCommande.getcomdatehretrait());
            txtPreparee.Text = "Non";           
            txtClinum.Text = Convert.ToString(laCommande.getclient().getclinum());
            //Infos table commander grd
            grdCommander1.Rows.Clear();
            PasserelleCommander.afficherCommander(laCommande.getcomnum());
            for (int i = 0; i < varglobale.lesCommander.Count(); i++)
            {
                grdCommander1.Rows.Add(varglobale.lesCommander[i].getpronum(), varglobale.lesProduits[i].getlib(), varglobale.lesProduits[i].getprix() + " €", varglobale.lesCommander[i].getquantite());
            }
        }

        //Bouton retour au menu
        private void btnRetour_Click(object sender, EventArgs e)
        {
            Form frmMenu = new frmMenu();
            frmMenu.Show();
            this.Hide();
        }

        //Bouton pour rendre la commande sélectionnée préparée
        private void btnprepare_Click(object sender, EventArgs e)
        {
            if (cboNonLNonP.SelectedIndex != -1)
            {
                PasserelleCommande.CommandePrepare(NonPNonL[cboNonLNonP.SelectedIndex]);
                MessageBox.Show("La commande a été inscrite comme préparée");
                frmCommande_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une commande dans la liste déroulante des commandes non préparées et non livrées");
            }
            
        }

        //Boutons pour rendre la commande sélectionnée livrée
        private void btnlivre_Click(object sender, EventArgs e)
        {
            if (cboNonLOuiP.SelectedIndex != -1)
            {
                PasserelleCommande.CommandeLivre(OuiPNonL[cboNonLOuiP.SelectedIndex]);
                MessageBox.Show("La commande a été inscrite comme livrée");
                frmCommande_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une commande dans la liste déroulante des commandes préparées et non livrées");
            }
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            //
        }

        private void frmCommande_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
