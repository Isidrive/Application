using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PPE3_Udrive
{
    class Categorie
    {
        private int num;
        private string lib;
        private string img;
     
        public  Categorie (int unNum, string unLib, string uneImg)
        {
            num = unNum;
            lib = unLib;
            img = uneImg;
        }

        public int getNum()
        {
            return num;
        }

        public string getLib()
        {
            return lib;
        }

        public string getImg()
        {
            return img;
        }
    }
}
