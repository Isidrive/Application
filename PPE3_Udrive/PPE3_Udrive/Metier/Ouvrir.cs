using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PPE3_Udrive
{
    class Ouvrir
    {
        private DateTime heuredeb;
        private DateTime heurefin;
        private int journum;
        private string jourlib;
        private Magasin leMagasin;

        public Ouvrir(DateTime unheuredeb, DateTime unheurefin, Magasin unMagasin, int unjournum, string unjourlib)
        {
            heuredeb = unheuredeb;
            heurefin = unheurefin;
            journum = unjournum;
            jourlib = unjourlib;
            leMagasin = unMagasin;

        }
        public Magasin getmagasin()
        {
            return leMagasin;
        }
        public DateTime getheuredeb()
        {
            return heuredeb;
        }
        public DateTime getheurefin()
        {
            return heurefin;
        }
        public int getjournum()
        {
            return journum;
        }
        public string getjourlib()
        {
            return jourlib;
        }
    }
}
