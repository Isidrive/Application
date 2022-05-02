using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PPE3_Udrive
{
    class Commander
    {
        private int quantite;
        private int pronum;
        private int comnum;

     
        public  Commander (int uneQuantite, int unPronum, int uneComnum)
        {
            quantite = uneQuantite;
            pronum = unPronum;
            comnum = uneComnum;
        }

        public int getquantite()
        {
            return quantite;
        }

        public int getpronum()
        {
            return pronum;
        }

        public int getcomnum()
        {
            return comnum;
        }
    }
}
