using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IniParser;
using IniParser.Model;

namespace PPE3_Udrive
{
    public partial class identification : Form
    {

        public identification()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            var parser = new FileIniDataParser();
            IniData data = parser.ReadFile(Application.StartupPath + "\\settings.ini");
            varglobale.driver = data["database"]["Driver"];
            varglobale.server = data["database"]["SERVER"];
            varglobale.bd = data["database"]["database"];
            varglobale.login = data["database"]["uid"];
            varglobale.mdp = data["database"]["pwd"];
            varglobale.port = data["database"]["port"];
            varglobale.unlistMagasin = PasserelleMagasin.ChargerMagasin();
            for (int i = 0; i < varglobale.unlistMagasin.Count(); i++)
            {
                cboMagasin.Items.Add(varglobale.unlistMagasin[i].getnom());
            }


        }

        private void btnconnection_Click(object sender, EventArgs e)
        {
            //Vérifie qu'un magasin soit sélectionné dans la liste déroulante
            if (cboMagasin.SelectedIndex != -1)
            {
                //Vérifie que le mot de passe correspond au magasin
                if (PasserelleMagasin.verif(varglobale.unlistMagasin[cboMagasin.SelectedIndex].getnum(), txtmdp.Text) == true)
                {
                    Form frmMenu = new frmMenu();
                    frmMenu.Show();
                    // Cache seulement, comment le close sans tout fermer ? Ne marche pas comme les autres car c'est le form mère
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Mauvais mot de passe, réessayer");
                    txtmdp.Clear();
                    txtmdp.Select();
                }
            }
            else
            {
                MessageBox.Show("Veuillez séléctionner un magasin dans la liste déroulante");
            }
            
        }

        //Appuie sur le bouton connexion quand on appuie sur ENTRER en étant sur le txtmdp
        private void txtmdp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnconnection_Click(sender, e);
            }
        }

        private void identification_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
