using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data.Odbc;
using IniParser;
using IniParser.Model;

namespace PPE3_Udrive
{
    class PasserelleMagasin
    {

        // Bool vérification de l'identification du gérant du magasin
        public static bool verif(int num, string mdp)
        {
            bool fin = false;
            varglobale.cnn = new OdbcConnection();
            varglobale.cmd = new OdbcCommand();
            varglobale.cnn.ConnectionString = "Driver=" + varglobale.driver + ";SERVER=" + varglobale.server + ";port=" + varglobale.port + ";Database=" + varglobale.bd + ";uid=" + varglobale.login + ";pwd=" + varglobale.mdp;
            varglobale.cnn.Open();
            varglobale.cmd.Connection = varglobale.cnn;
            varglobale.cmd.CommandText = "select * from magasin where magnum =" + num + " and magmdp ='" + mdp + "'";
            varglobale.cmd.Connection = varglobale.cnn;
            OdbcDataReader drr = varglobale.cmd.ExecuteReader();
            fin = drr.Read();
            if (fin == true)
            {
                varglobale.unMagasin = new Magasin(Convert.ToInt32(drr["magnum"]), Convert.ToString(drr["magnom"]), Convert.ToString(drr["magadr1"]), Convert.ToString(drr["magcp"]), Convert.ToString(drr["magville"]), Convert.ToString(drr["magtel"]), Convert.ToString(drr["magmdp"]), Convert.ToString(drr["magadr2"]));
            }
            drr.Close();
            varglobale.cnn.Close();
            return (fin);
        }

        // Chargement de tous les magasin (pour l'identification)
        public static List<Magasin> ChargerMagasin()
        {
            bool fin = false;
            varglobale.cnn = new OdbcConnection();
            varglobale.cmd = new OdbcCommand();
            varglobale.cnn.ConnectionString = "Driver=" + varglobale.driver + ";SERVER=" + varglobale.server + ";port=" + varglobale.port + ";Database=" + varglobale.bd + ";uid=" + varglobale.login + ";pwd=" + varglobale.mdp;
            varglobale.cnn.Open();
            varglobale.cmd.Connection = varglobale.cnn;
            List<Magasin> unlistMagasin = new List<Magasin>();
            Magasin unMagasin;
            varglobale.cmd.CommandText = "select * from magasin";
            varglobale.cmd.Connection = varglobale.cnn;
            OdbcDataReader drr = varglobale.cmd.ExecuteReader();
            fin = drr.Read();
            while (fin == true)
            {
                unMagasin = new Magasin(Convert.ToInt32(drr["magnum"]), Convert.ToString(drr["magnom"]), Convert.ToString(drr["magadr1"]), Convert.ToString(drr["magcp"]), Convert.ToString(drr["magville"]), Convert.ToString(drr["magtel"]), Convert.ToString(drr["magmdp"]), Convert.ToString(drr["magadr2"]));
                unlistMagasin.Add(unMagasin);
                fin = drr.Read();
            }
            drr.Close();
            varglobale.cnn.Close();
            return (unlistMagasin);
        }

        // Méthode Modification de l'objet magasin
        public static void ModifierObjetMagasin(Magasin unMagasin)
        {
            varglobale.cnn = new OdbcConnection();
            varglobale.cmd = new OdbcCommand();
            varglobale.cnn.ConnectionString = "Driver=" + varglobale.driver + ";SERVER=" + varglobale.server + ";port=" + varglobale.port + ";Database=" + varglobale.bd + ";uid=" + varglobale.login + ";pwd=" + varglobale.mdp;
            varglobale.cnn.Open();
            varglobale.cmd.Connection = varglobale.cnn;
            varglobale.cmd.CommandText = "update magasin set magnom = '" + unMagasin.getnom() + "', magadr1 ='" + unMagasin.getadr1() + "', magadr2 ='" + unMagasin.getadr2() + "',magcp = '" + unMagasin.getcp() + "',magville = '" + unMagasin.getville() + "',magtel = '" + unMagasin.gettel() + "',magmdp = '" + unMagasin.getmdp() + "' where magnum = " + varglobale.unMagasin.getnum();
            varglobale.cmd.Connection = varglobale.cnn;
            varglobale.cmd.ExecuteNonQuery();
            varglobale.cnn.Close();
        }

        // Méthode pour charger les stocks dans un Magasin, ne sert à rien pour les fonctionnalités à présenté
        public static void ChargerStock(Magasin unMagasin)
        {
            bool fin = false;
            varglobale.cnn = new OdbcConnection();
            varglobale.cmd = new OdbcCommand();
            varglobale.cnn.ConnectionString = "Driver=" + varglobale.driver + ";SERVER=" + varglobale.server + ";port=" + varglobale.port + ";Database=" + varglobale.bd + ";uid=" + varglobale.login + ";pwd=" + varglobale.mdp;
            varglobale.cnn.Open();
            varglobale.cmd.Connection = varglobale.cnn;
            List<Stock> unlistStock = new List<Stock>();
            varglobale.cmd.CommandText = "select * from stocker inner join produit on produit.pronum = stocker.pronum where magnum = " + unMagasin.getnum();
            varglobale.cmd.Connection = varglobale.cnn;
            OdbcDataReader drr = varglobale.cmd.ExecuteReader();
            fin = drr.Read();
            while (fin == true)
            {
                Stock unStock = new Stock(unMagasin, new Produit(Convert.ToInt32(drr["pronum"]), Convert.ToString(drr["prolib"]), Convert.ToSingle(drr["proprix"]),
                    new Soucat(Convert.ToInt32(drr["sounum"]), Convert.ToString(drr["soulib"]), new Categorie(Convert.ToInt32(drr["catnum"]), Convert.ToString(drr["catlib"]), Convert.ToString(drr["catimg"]))), Convert.ToString(drr["proimg"])),Convert.ToInt32(drr["qte"]));
                unMagasin.getlesstock().Add(unStock);
                fin = drr.Read();
            }
            drr.Close();
            varglobale.cnn.Close();
           
        }
    }
}
