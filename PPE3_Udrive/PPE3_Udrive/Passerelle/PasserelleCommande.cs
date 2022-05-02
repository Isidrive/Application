using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data.Odbc;
using IniParser;

namespace PPE3_Udrive
{
    class PasserelleCommande
    {
        public static List<Commande> afficherCommande()
        {
            varglobale.lesCommandes.Clear();
            varglobale.cnn = new OdbcConnection();
            varglobale.cmd = new OdbcCommand();
            varglobale.cnn.ConnectionString = "Driver=" + varglobale.driver + ";SERVER=" + varglobale.server + ";port=" + varglobale.port + ";Database=" + varglobale.bd + ";uid=" + varglobale.login + ";pwd=" + varglobale.mdp;
            varglobale.cnn.Open();
            varglobale.cmd.Connection = varglobale.cnn;
            varglobale.cmd.CommandText = "select * from commande inner join client on commande.clinum = client.clinum inner join magasin on client.magnum = magasin.magnum where client.magnum = " + varglobale.unMagasin.getnum();
            varglobale.cmd.Connection = varglobale.cnn;
            OdbcDataReader drr = varglobale.cmd.ExecuteReader();
            while (drr.Read())
            {
                varglobale.lesCommandes.Add(new Commande(Convert.ToInt32(drr["comnum"]), Convert.ToString(drr["comdateh"]), Convert.ToString(drr["comdatehretrait"]), Convert.ToInt32(drr["comprepareok"]), Convert.ToInt32(drr["comlivreok"]), new Client(Convert.ToInt32(drr["clinum"]), Convert.ToString(drr["clinom"]), Convert.ToString(drr["cliprenom"]), Convert.ToString(drr["cliadr1"]), Convert.ToString(drr["clicp"]), Convert.ToString(drr["cliville"]), Convert.ToString(drr["clitel"]), Convert.ToString(drr["climail"]), Convert.ToString(drr["climdp"]), new Magasin(Convert.ToInt32(drr["magnum"]), Convert.ToString(drr["magnom"]), Convert.ToString(drr["magadr1"]), Convert.ToString(drr["magadr2"]), Convert.ToString(drr["magcp"]), Convert.ToString(drr["magville"]), Convert.ToString(drr["magtel"]), Convert.ToString(drr["magmdp"])), Convert.ToString(drr["cliadr2"]))));
            }
            drr.Close();
            varglobale.cnn.Close();
            return varglobale.lesCommandes;
        }

        public static Commande laCommande(int comnum)
        {
            varglobale.cnn = new OdbcConnection();
            varglobale.cmd = new OdbcCommand();
            varglobale.cnn.ConnectionString = "Driver=" + varglobale.driver + ";SERVER=" + varglobale.server + ";port=" + varglobale.port + ";Database=" + varglobale.bd + ";uid=" + varglobale.login + ";pwd=" + varglobale.mdp;
            varglobale.cnn.Open();
            varglobale.cmd.Connection = varglobale.cnn;
            varglobale.cmd.CommandText = "select * from commande inner join client on commande.clinum = client.clinum inner join magasin on client.magnum = magasin.magnum where comnum = " + comnum;
            varglobale.cmd.Connection = varglobale.cnn;
            OdbcDataReader drr = varglobale.cmd.ExecuteReader();
            drr.Read();
            Commande laCommande = new Commande(Convert.ToInt32(drr["comnum"]), Convert.ToString(drr["comdateh"]), Convert.ToString(drr["comdatehretrait"]), 
                Convert.ToInt32(drr["comprepareok"]), Convert.ToInt32(drr["comlivreok"]), new Client(Convert.ToInt32(drr["clinum"]), Convert.ToString(drr["clinom"]), 
                    Convert.ToString(drr["cliprenom"]), Convert.ToString(drr["cliadr1"]), Convert.ToString(drr["clicp"]), Convert.ToString(drr["cliville"]), 
                    Convert.ToString(drr["clitel"]), Convert.ToString(drr["climail"]), Convert.ToString(drr["climdp"]), new Magasin(Convert.ToInt32(drr["magnum"]), 
                        Convert.ToString(drr["magnom"]), Convert.ToString(drr["magadr1"]), Convert.ToString(drr["magadr2"]), Convert.ToString(drr["magcp"]), 
                        Convert.ToString(drr["magville"]), Convert.ToString(drr["magtel"]), Convert.ToString(drr["magmdp"])), Convert.ToString(drr["cliadr2"])));  
            drr.Close();
            varglobale.cnn.Close();
            return laCommande;
        }

        public static void CommandePrepare(Commande uneCommande)
        {
            int num = uneCommande.getcomnum();
            varglobale.cnn = new OdbcConnection();
            varglobale.cmd = new OdbcCommand();
            varglobale.cnn.ConnectionString = "Driver=" + varglobale.driver + ";SERVER=" + varglobale.server + ";port=" + varglobale.port + ";Database=" + varglobale.bd + ";uid=" + varglobale.login + ";pwd=" + varglobale.mdp;
            varglobale.cnn.Open();
            varglobale.cmd.Connection = varglobale.cnn;
            varglobale.cmd.CommandText = "update commande set comprepareok = 1 where comnum = " + num;
            varglobale.cmd.Connection = varglobale.cnn;
            varglobale.cmd.ExecuteNonQuery();
            varglobale.cnn.Close();

        }
        public static void CommandeLivre(Commande uneCommande)
        {
            int num = uneCommande.getcomnum();
            varglobale.cnn = new OdbcConnection();
            varglobale.cmd = new OdbcCommand();
            varglobale.cnn.ConnectionString = "Driver=" + varglobale.driver + ";SERVER=" + varglobale.server + ";port=" + varglobale.port + ";Database=" + varglobale.bd + ";uid=" + varglobale.login + ";pwd=" + varglobale.mdp;
            varglobale.cnn.Open();
            varglobale.cmd.Connection = varglobale.cnn;
            varglobale.cmd.CommandText = "update commande set comlivreok = 1 where comnum = " + num;
            varglobale.cmd.Connection = varglobale.cnn;
            varglobale.cmd.ExecuteNonQuery();
            varglobale.cnn.Close();

        }

    }
}
