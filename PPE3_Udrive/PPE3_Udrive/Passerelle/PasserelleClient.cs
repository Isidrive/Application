using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data.Odbc;
using IniParser;

namespace PPE3_Udrive
{
    class PasserelleClient
    {
        //public static List<Client> chargementLesClients()
        //{
        //    int numMag = varglobale.numMag;
        //    varglobale.cnn = new OdbcConnection();
        //    varglobale.cmd = new OdbcCommand();
        //    varglobale.cnn.ConnectionString = "Driver=" + varglobale.driver + ";SERVER=" + varglobale.server + ";port=" + varglobale.port + ";Database=" + varglobale.bd + ";uid=" + varglobale.login + ";pwd=" + varglobale.mdp;
        //    varglobale.cnn.Open();
        //    varglobale.cmd.Connection = varglobale.cnn;
        //    varglobale.cmd.CommandText = "select * from client inner join magasin on client.magnum = magasin.magnum where magnum = " + numMag ;
        //    varglobale.cmd.Connection = varglobale.cnn;
        //    OdbcDataReader drr = varglobale.cmd.ExecuteReader();
        //    while (drr.Read())
        //    {
        //        varglobale.lesClients.Add(new Client(Convert.ToInt32(drr["clinum"]), Convert.ToString(drr["clinom"]), Convert.ToString(drr["cliprenom"]), Convert.ToString(drr["cliadr1"]), Convert.ToString(drr["cliadr2"]), Convert.ToString(drr["cliville"]), Convert.ToString(drr["clitel"]), Convert.ToString(drr["climail"]), Convert.ToString(drr["climdp"]), new Magasin(Convert.ToInt32(drr["magnum"]), Convert.ToString(drr["magnom"]), Convert.ToString(drr["magadr1"]), Convert.ToString(drr["magadr2"]), Convert.ToString(drr["magcp"]), Convert.ToString(drr["magville"]), Convert.ToString(drr["magtel"]), Convert.ToString(drr["magmdp"])), Convert.ToString(drr["cliadr2"])));
        //    }
        //    drr.Close();
        //    varglobale.cnn.Close();
        //    return varglobale.lesClients;
        //}


    }
}
