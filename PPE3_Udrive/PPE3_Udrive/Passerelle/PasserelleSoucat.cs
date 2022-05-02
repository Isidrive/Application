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
    class PasserelleSoucat
    {
        public static List<Soucat> chargementSouCateg(int numCat)
        {
            varglobale.lesSousCategories.Clear();
            varglobale.cnn = new OdbcConnection();
            varglobale.cmd = new OdbcCommand();
            varglobale.cnn.ConnectionString = "Driver=" + varglobale.driver + ";SERVER=" + varglobale.server + ";port=" + varglobale.port + ";Database=" + varglobale.bd + ";uid=" + varglobale.login + ";pwd=" + varglobale.mdp;
            varglobale.cnn.Open();
            varglobale.cmd.Connection = varglobale.cnn;
            varglobale.cmd.CommandText = "select * from soucat inner join categorie on soucat.catnum = categorie.catnum where soucat.catnum = " + numCat;
            varglobale.cmd.Connection = varglobale.cnn;
            OdbcDataReader drr = varglobale.cmd.ExecuteReader();
            while (drr.Read())
            {
                varglobale.lesSousCategories.Add(new Soucat(Convert.ToInt32(drr["sounum"]), Convert.ToString(drr["soulib"]), new Categorie(Convert.ToInt32(drr["catnum"]), Convert.ToString(drr["catlib"]), Convert.ToString(drr["catimg"]))));
            }
            drr.Close();
            varglobale.cnn.Close();
            return varglobale.lesSousCategories;
        }

        public static int numSoucat(string libsoucat)
        {
            int lenum;
            varglobale.cnn = new OdbcConnection();
            varglobale.cmd = new OdbcCommand();
            varglobale.cnn.ConnectionString = "Driver=" + varglobale.driver + ";SERVER=" + varglobale.server + ";port=" + varglobale.port + ";Database=" + varglobale.bd + ";uid=" + varglobale.login + ";pwd=" + varglobale.mdp;
            varglobale.cnn.Open();
            varglobale.cmd.Connection = varglobale.cnn;
            varglobale.cmd.CommandText = "select sounum from soucat where soulib = '" + libsoucat + "'";
            varglobale.cmd.Connection = varglobale.cnn;
            OdbcDataReader drr = varglobale.cmd.ExecuteReader();
            drr.Read();
            lenum = Convert.ToInt32(drr["sounum"]);
            drr.Close();
            varglobale.cnn.Close();
            return lenum;
        }
    }
}
