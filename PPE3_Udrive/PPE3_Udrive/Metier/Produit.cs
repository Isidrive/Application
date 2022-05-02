using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PPE3_Udrive
{
    class Produit
    {
        private int pronum;
        private string prolib;
        private Single proprix;
        private string proimg;
        private Soucat soucat;

        public Produit(int unPronum, string unProlib, Single unProprix, Soucat uneSoucat, string unProimg = null)
        {
            pronum = unPronum;
            prolib = unProlib;
            proprix = unProprix;
            proimg = unProimg;
            soucat = uneSoucat;
            if (unProimg != null)
            {
                proimg = unProimg;
            }
        }

        public int getnum()
        {
            return pronum;
        }

        public string getlib()
        {
            return prolib;
        }

        public Single getprix()
        {
            return proprix;
        }

        public string getimg()
        {
            return proimg;
        }

        public Soucat getsoucat()
        {
            return soucat;
        }

    }
}
