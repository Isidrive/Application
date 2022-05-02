using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data.Odbc;
using IniParser;

namespace PPE3_Udrive
{
    class PasserelleCommander
    {
        public static void afficherCommander(int comnum)
        {
            varglobale.lesCommander.Clear();
            varglobale.lesProduits.Clear();
            varglobale.cnn = new OdbcConnection();
            varglobale.cmd = new OdbcCommand();
            varglobale.cnn.ConnectionString = "Driver=" + varglobale.driver + ";SERVER=" + varglobale.server + ";port=" + varglobale.port + ";Database=" + varglobale.bd + ";uid=" + varglobale.login + ";pwd=" + varglobale.mdp;
            varglobale.cnn.Open();
            varglobale.cmd.Connection = varglobale.cnn;
            varglobale.cmd.CommandText = "select * from commander inner join produit on commander.pronum = produit.pronum inner join soucat on produit.sounum = soucat.sounum inner join categorie on categorie.catnum = soucat.catnum where comnum = " + comnum;
            varglobale.cmd.Connection = varglobale.cnn;
            OdbcDataReader drr = varglobale.cmd.ExecuteReader();
            while (drr.Read())
            {
                varglobale.lesCommander.Add(new Commander(Convert.ToInt32(drr["quantite"]), Convert.ToInt32(drr["pronum"]), Convert.ToInt32(drr["comnum"])));
                varglobale.lesProduits.Add(new Produit(Convert.ToInt32(drr["pronum"]), Convert.ToString(drr["prolib"]), Convert.ToSingle(drr["proprix"]),
                    new Soucat(Convert.ToInt32(drr["sounum"]), Convert.ToString(drr["soulib"]), new Categorie(Convert.ToInt32(drr["catnum"]), Convert.ToString(drr["catlib"]), Convert.ToString(drr["catimg"]))), Convert.ToString(drr["proimg"])));
            }
            drr.Close();
            varglobale.cnn.Close();
        }

    }
}
