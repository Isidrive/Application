using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data.Odbc;
using IniParser;

namespace PPE3_Udrive
{
    class PasserelleStock
    {
        public static void ajouterproduitStock(Magasin unMagasin, Produit unProduit, int unqte)
        {
            varglobale.cnn = new OdbcConnection();
            varglobale.cmd = new OdbcCommand();
            varglobale.cnn.ConnectionString = "Driver=" + varglobale.driver + ";SERVER=" + varglobale.server + ";port=" + varglobale.port + ";Database=" + varglobale.bd + ";uid=" + varglobale.login + ";pwd=" + varglobale.mdp;
            varglobale.cnn.Open();
            varglobale.cmd.Connection = varglobale.cnn;
            varglobale.cmd.CommandText = "insert into stocker(magnum,pronum,qtestock) values (" + unMagasin.getnum() + "," + unProduit.getnum() + "," + unqte + ")";
            varglobale.cmd.Connection = varglobale.cnn;
            varglobale.cmd.ExecuteScalar();
            varglobale.cnn.Close();
        }
    }
}
