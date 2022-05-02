using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data.Odbc;
using IniParser;

namespace PPE3_Udrive
{
    class varglobale
    {
        public static OdbcConnection cnn;
        public static OdbcCommand cmd;
        public static OdbcDataReader drr;
        public static string driver;
        public static string server;
        public static string bd;
        public static string login;
        public static string mdp;
        public static string port;
        public static Magasin unMagasin;
        public static List<Categorie> lesCategories = new List<Categorie>();
        public static List<Soucat> lesSousCategories = new List<Soucat>();
        public static List<Commande> lesCommandes = new List<Commande>();
        public static List<Commander> lesCommander = new List<Commander>();
        public static List<Produit> lesProduits = new List<Produit>();
        public static List<Magasin> unlistMagasin = new List<Magasin>();
        //public static List<Client> lesClients = new List<Client>();
    }
}
