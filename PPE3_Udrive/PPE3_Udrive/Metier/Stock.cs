using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PPE3_Udrive
{
    class Stock
    {
        private Magasin leMagasin;
        private Produit Leproduit;
        private int qte;

        public Stock(Magasin unMagasin, Produit unProduit, int unqte)
        {
            leMagasin = unMagasin;
            Leproduit = unProduit;
            qte = unqte;}


         public Magasin getMagasin()
        {
            return leMagasin;
        }
         public Produit getProduit()
        {
            return Leproduit;
        }
         public int getqte()
        {
            return qte;
        }


        
        }





    }

