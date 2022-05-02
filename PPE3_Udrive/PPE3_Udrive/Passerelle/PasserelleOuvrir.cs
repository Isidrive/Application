using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IniParser;
using IniParser.Model;
using System.Data.OleDb;
using System.Data.Odbc;

namespace PPE3_Udrive
{
    class PasserelleOuvrir
    {
        public static void ChargementOuvrir(Magasin unMagasin)
        {
            unMagasin.getlesouvertures().Clear();
            bool fin = false;
            varglobale.cnn = new OdbcConnection();
            varglobale.cmd = new OdbcCommand();
            varglobale.cnn.ConnectionString = "Driver=" + varglobale.driver + ";SERVER=" + varglobale.server + ";port=" + varglobale.port + ";Database=" + varglobale.bd + ";uid=" + varglobale.login + ";pwd=" + varglobale.mdp;
            varglobale.cnn.Open();
            varglobale.cmd.Connection = varglobale.cnn;
            varglobale.cmd.CommandText = "select * from ouvrir inner join joursemaine on joursemaine.jounum = ouvrir.jounum where magnum =" + unMagasin.getnum();
            varglobale.cmd.Connection = varglobale.cnn;
            OdbcDataReader drr = varglobale.cmd.ExecuteReader();
            fin = drr.Read();
            while (fin == true)
            {
                unMagasin.getlesouvertures().Add(new Ouvrir(Convert.ToDateTime(drr["heuredeb"]), Convert.ToDateTime(drr["heurefin"]), unMagasin, Convert.ToInt32(drr["jounum"]), Convert.ToString(drr["joulib"])));
                fin = drr.Read();

            }
            drr.Close();
            varglobale.cnn.Close();
        }
        public static void ModifierHoraireMagasin(DateTime heuredeb, DateTime heurefin, int numjour)
        {
            varglobale.cnn = new OdbcConnection();
            varglobale.cmd = new OdbcCommand();
            varglobale.cnn.ConnectionString = "Driver=" + varglobale.driver + ";SERVER=" + varglobale.server + ";port=" + varglobale.port + ";Database=" + varglobale.bd + ";uid=" + varglobale.login + ";pwd=" + varglobale.mdp;
            varglobale.cnn.Open();
            varglobale.cmd.Connection = varglobale.cnn;
            varglobale.cmd.CommandText = "update ouvrir set heuredeb = '" + heuredeb + "', heurefin ='" + heurefin + "' where jounum = " + numjour + " and magnum = " + varglobale.unMagasin.getnum();
            varglobale.cmd.Connection = varglobale.cnn;
            varglobale.cmd.ExecuteNonQuery();
            varglobale.cnn.Close();

        }

    }
}
