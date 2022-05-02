using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PPE3_Udrive
{
    class Soucat
    {
        private int sounum;
        private string soulib;
        private Categorie categ;
     
        public  Soucat (int unNum, string unLib, Categorie laCateg )
        {
            sounum = unNum;
            soulib = unLib;
            categ = laCateg;
        }

        public int getNum()
        {
            return sounum;
        }

        public string getLib()
        {
            return soulib;
        }

        public Categorie getCateg()
        {
            return categ;
        }

    }
}
