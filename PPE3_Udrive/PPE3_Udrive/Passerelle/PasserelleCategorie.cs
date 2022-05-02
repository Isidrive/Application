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
    class PasserelleCategorie
    {
        public static List<Categorie> chargementCateg()
        {
            varglobale.cnn = new OdbcConnection();
            varglobale.cmd = new OdbcCommand();
            varglobale.cnn.ConnectionString = "Driver=" + varglobale.driver + ";SERVER=" + varglobale.server + ";port=" + varglobale.port + ";Database=" + varglobale.bd + ";uid=" + varglobale.login + ";pwd=" + varglobale.mdp;
            varglobale.cnn.Open();
            varglobale.cmd.Connection = varglobale.cnn;
            varglobale.cmd.CommandText = "select * from categorie";
            varglobale.cmd.Connection = varglobale.cnn;
            OdbcDataReader drr = varglobale.cmd.ExecuteReader();
            while (drr.Read())
            {
                varglobale.lesCategories.Add(new Categorie(Convert.ToInt32(drr["catnum"]), Convert.ToString(drr["catlib"]), Convert.ToString(drr["catimg"])));    
            }
            drr.Close();
            varglobale.cnn.Close();
            return varglobale.lesCategories;
        }


    }
}
