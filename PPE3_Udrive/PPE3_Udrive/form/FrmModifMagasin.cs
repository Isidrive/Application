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
    public partial class FrmModifMagasin : Form
    {
        public FrmModifMagasin()
        {
            InitializeComponent();
            InitializeTimePicker();
        }

        private void FrmModifMagasin_Load(object sender, EventArgs e)
        {


            grdjoursemaine.Rows.Clear();

            // Affiche les paramètres de l'objet magasin de varglobale dans les txt
            txtadr2.Text = varglobale.unMagasin.getadr2();
            txtcp.Text = varglobale.unMagasin.getcp();
            txtmdp.Text = varglobale.unMagasin.getmdp();
            txtville.Text = varglobale.unMagasin.getville();
            txtadr1.Text = varglobale.unMagasin.getadr1();
            txttel.Text = varglobale.unMagasin.gettel();
            txtnom.Text = varglobale.unMagasin.getnom();
            PasserelleOuvrir.ChargementOuvrir(varglobale.unMagasin);

            //Affichage des horaires d'ouverture dans le grd
            for (int i = 0; i < varglobale.unMagasin.getlesouvertures().Count(); i++)
            {
                grdjoursemaine.Rows.Add(varglobale.unMagasin.getlesouvertures()[i].getjourlib(), Convert.ToString(varglobale.unMagasin.getlesouvertures()[i].getheuredeb().ToString("HH:mm")), Convert.ToString(varglobale.unMagasin.getlesouvertures()[i].getheurefin().ToString("HH:mm")));
            }
            timePicker.Value = varglobale.unMagasin.getlesouvertures()[grdjoursemaine.CurrentRow.Index].getheuredeb();
            TimePicker2.Value = varglobale.unMagasin.getlesouvertures()[grdjoursemaine.CurrentRow.Index].getheurefin();

        }

        private void InitializeTimePicker()
        {
            // Ne permettre que la saisis de l'heure
            timePicker = new DateTimePicker();
            timePicker.Format = DateTimePickerFormat.Time;
            timePicker.ShowUpDown = true;
            timePicker.Location = new Point(345, 247);
            timePicker.Width = 100;
            Controls.Add(timePicker);
            TimePicker2 = new DateTimePicker();
            TimePicker2.Format = DateTimePickerFormat.Time;
            TimePicker2.ShowUpDown = true;
            TimePicker2.Location = new Point(523, 247);
            TimePicker2.Width = 100;
            Controls.Add(TimePicker2);


        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    // Modification de l'objet Magasin
        //    varglobale.unMagasin.setadr1(txtadr1.Text);
        //    varglobale.unMagasin.setadr2(txtadr2.Text);
        //    varglobale.unMagasin.setcp(txtcp.Text);
        //    varglobale.unMagasin.setmdp(txtmdp.Text);
        //    varglobale.unMagasin.setnom(txtnom.Text);
        //    varglobale.unMagasin.settel(txttel.Text);
        //    varglobale.unMagasin.setville(txtville.Text);
        //    PasserelleMagasin.ModifierObjetMagasin(varglobale.unMagasin);
        //    MessageBox.Show("Modification effectué");
        //}

        private void grdjoursemaine_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Changement de l'horaire dans le TimePicker
            timePicker.Value = varglobale.unMagasin.getlesouvertures()[grdjoursemaine.CurrentRow.Index].getheuredeb();
            TimePicker2.Value = varglobale.unMagasin.getlesouvertures()[grdjoursemaine.CurrentRow.Index].getheurefin();
            labelouvre.Text = "Heure d'ouverture de : " + varglobale.unMagasin.getlesouvertures()[grdjoursemaine.CurrentRow.Index].getjourlib();
            labelferm.Text = "Heure de fermeture de : " + varglobale.unMagasin.getlesouvertures()[grdjoursemaine.CurrentRow.Index].getjourlib();
        }

        private void btnmodif_Click(object sender, EventArgs e)
        {
            // Modification de l'objet Magasin
            varglobale.unMagasin.setadr1(txtadr1.Text);
            varglobale.unMagasin.setadr2(txtadr2.Text);
            varglobale.unMagasin.setcp(txtcp.Text);
            varglobale.unMagasin.setmdp(txtmdp.Text);
            varglobale.unMagasin.setnom(txtnom.Text);
            varglobale.unMagasin.settel(txttel.Text);
            varglobale.unMagasin.setville(txtville.Text);
            PasserelleMagasin.ModifierObjetMagasin(varglobale.unMagasin);
            MessageBox.Show("Modification effectué");
        }

        private void btnvalider_Click(object sender, EventArgs e)
        {
            // Modification de l'horaire du magasin sur le jour sélectionné
            PasserelleOuvrir.ModifierHoraireMagasin(timePicker.Value, TimePicker2.Value, grdjoursemaine.CurrentRow.Index + 1);
            MessageBox.Show("L'horaire du jour à été modifié");
            FrmModifMagasin_Load(sender, e);
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            Form frmMenu = new frmMenu();
            frmMenu.Show();
            this.Hide();
        }

        private void FrmModifMagasin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }









     


    }
}
