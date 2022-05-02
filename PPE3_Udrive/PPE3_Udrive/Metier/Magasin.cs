using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PPE3_Udrive
{
    class Magasin
    {
        private int magnum;
        private string magnom;
        private string magadr1;
        private string magadr2;
        private string magcp;
        private string magville;
        private string magtel;
        private string magmdp;
        private List<Ouvrir> lesouvertures;
        private List<Stock> lesstocks;
        // rajouter ouverture (enlever de varglobale)



        public Magasin(int unmagnum, string unmagnom, string unmagadr1, string unmagcp, string unmagville, string unmagtel, string unmagmdp, string unmagadr2 = null)
        {
            magnum = unmagnum;
            magnom = unmagnom;
            magadr1 = unmagadr1;
            magcp = unmagcp;
            magville = unmagville;
            magtel = unmagtel;
            magmdp = unmagmdp;
            if (unmagadr2 != null)
            {
                magadr2 = unmagadr2;
            }
            lesouvertures = new List<Ouvrir>();
        }

        //Modifier le nom : lesouvertures
        public List<Ouvrir> getlesouvertures()
        {
            return lesouvertures;
        }
        public List<Stock> getlesstock()
        {
            return lesstocks;
        }

        public string getnom()
        {
            return magnom;
        }
        public int getnum()
        {
            return magnum;
        }
        public string getmdp()
        {
            return magmdp;
        }
        public string getadr1()
        {
            return magadr1;
        }
        public string getadr2()
        {
            return magadr2;
        }
        public string getcp()
        {
            return magcp;
        }
        public string getville()
        {
            return magville;
        }
        public string gettel()
        {
            return magtel;
        }
        public void setnom(string unnom)
        {
            magnom = unnom;
        }
        public void setnum(int unnum)
        {
            magnum = unnum;
        }
        public void setmdp(string unmdp)
        {
            magmdp = unmdp;
        }
        public void setadr1(string unadr1)
        {
            magadr1 = unadr1;
        }
        public void setadr2(string unadr2)
        {
            magadr2 = unadr2;
        }
        public void setcp(string uncp)
        {
            magcp = uncp;
        }
        public void setville(string uneville)
        {
            magville = uneville;
        }
        public void settel(string untel)
        {
            magtel = untel;
            
        }

        public List<Commande> CommandeNonPnonL(List<Commande> uneliste)
        {
            List<Commande> NonPnonL = new List<Commande>();
            for (int i = 0; i < uneliste.Count(); i++)
            {
                if (uneliste[i].getcomlivreok() == 0 && uneliste[i].getcomprepareok() == 0)
                {
                    NonPnonL.Add(uneliste[i]);
                }
            }
            return NonPnonL;

        }

        public List<Commande> CommandeOuiPnonL(List<Commande> uneliste)
        {
            List<Commande> OuiPnonL = new List<Commande>();
            for (int i = 0; i < uneliste.Count(); i++)
            {
                if (uneliste[i].getcomlivreok() == 0 && uneliste[i].getcomprepareok() == 1)
                {
                    OuiPnonL.Add(uneliste[i]);
                }
            }
            return OuiPnonL;

        }
        public List<Commande> CommandeOuiPOuiL(List<Commande> uneliste)
        {
            List<Commande> OuiPOuiL = new List<Commande>();
            for (int i = 0; i < uneliste.Count(); i++)
            {
                if (uneliste[i].getcomlivreok() == 1 && uneliste[i].getcomprepareok() == 1)
                {
                    OuiPOuiL.Add(uneliste[i]);
                }
            }
            return OuiPOuiL;

        }

    }
}
