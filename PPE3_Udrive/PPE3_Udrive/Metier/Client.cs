using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PPE3_Udrive
{
    class Client
    {
        private int clinum;
        private string clinom;
        private string cliprenom;
        private string cliadr1;
        private string cliadr2;
        private string clicp;
        private string cliville;
        private string clitel;
        private string climail;
        private string climdp;
        private Magasin magasin;

        public  Client (int unClinum, string unClinom, string unCliprenom, string unCliadr1, string unClicp, string unCliville, string unClitel, string unClimail, string unClimdp, Magasin unMagasin, string unCliadr2 = null)
        {
            clinum = unClinum;
            clinom = unClinom;
            cliprenom = unCliprenom;
            cliadr1 = unCliadr1;
            clicp = unClicp;
            cliville = unCliville;
            clitel = unClitel;
            climail = unClimail;
            climdp = unClimdp;
            magasin = unMagasin;
            if (unCliadr2 != null)
            {
                cliadr2 = unCliadr2;
            }  
        }

        public int getclinum()
        {
            return clinum;
        }

        public string getclinom()
        {
            return clinom;
        }

        public string getcliprenom()
        {
            return cliprenom;
        }

        public string getcliadr1()
        {
            return cliadr1;
        }

        public string getcliadr2()
        {
            return cliadr2;
        }

        public string getclicp()
        {
            return clicp;
        }

        public string getcliville()
        {
            return cliville;
        }

        public string getclitel()
        {
            return clitel;
        }

        public string getclimail()
        {
            return climail;
        }

        public string getclimdp()
        {
            return climdp;
        }

        public Magasin getmagasin()
        {
            return magasin;
        }
       
    }
}
