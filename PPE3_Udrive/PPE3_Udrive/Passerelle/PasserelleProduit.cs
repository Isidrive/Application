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
    class PasserelleProduit
    {
        public static void ajoutproduit(string unLib, Single unPrix, int unSounum)
        {
            bool fin = false;
            varglobale.cnn = new OdbcConnection();
            varglobale.cmd = new OdbcCommand();
            varglobale.cnn.ConnectionString = "Driver=" + varglobale.driver + ";SERVER=" + varglobale.server + ";port=" + varglobale.port + ";Database=" + varglobale.bd + ";uid=" + varglobale.login + ";pwd=" + varglobale.mdp;
            varglobale.cnn.Open();
            varglobale.cmd.Connection = varglobale.cnn;
            varglobale.cmd.CommandText = "insert into produit(prolib, proprix, sounum) values ('" + unLib + "'," + unPrix + "," + unSounum + ")";
            varglobale.cmd.Connection = varglobale.cnn;
            OdbcDataReader drr = varglobale.cmd.ExecuteReader();
            fin = drr.Read();
            drr.Close();
            varglobale.cnn.Close();
        }
        public static Produit dernierproduit()
        {
            bool fin = false;
            varglobale.cnn = new OdbcConnection();
            varglobale.cmd = new OdbcCommand();
            varglobale.cnn.ConnectionString = "Driver=" + varglobale.driver + ";SERVER=" + varglobale.server + ";port=" + varglobale.port + ";Database=" + varglobale.bd + ";uid=" + varglobale.login + ";pwd=" + varglobale.mdp;
            varglobale.cnn.Open();
            varglobale.cmd.Connection = varglobale.cnn;
            varglobale.cmd.CommandText = "select * from produit inner join soucat on produit.sounum = soucat.sounum inner join categorie on soucat.catnum = categorie.catnum where pronum = (select MAX(pronum) from produit)";
            varglobale.cmd.Connection = varglobale.cnn;
            OdbcDataReader drr = varglobale.cmd.ExecuteReader();
            fin = drr.Read();
            Produit unproduit = new Produit(Convert.ToInt32(drr["pronum"]), Convert.ToString(drr["prolib"]), Convert.ToSingle(drr["proprix"]),
                    new Soucat(Convert.ToInt32(drr["sounum"]), Convert.ToString(drr["soulib"]), new Categorie(Convert.ToInt32(drr["catnum"]), Convert.ToString(drr["catlib"]), Convert.ToString(drr["catimg"]))), Convert.ToString(drr["proimg"]));
            drr.Close();
            varglobale.cnn.Close();
            return unproduit;
        }
    }
}
