using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PPE3_Udrive
{
    class Commande
    {
        private int comnum;
        private string comdateh;
        private string comdatehretrait;
        private int comprepareok;
        private int comlivreok;
        private Client leClient;

     
        public  Commande (int unComnum, string unComdateh, string unComdatehretrait, int unComprepareok, int unComlivreok, Client unClient)
        {
            comnum = unComnum;
            comdateh = unComdateh;
            comdatehretrait = unComdatehretrait;
            comprepareok = unComprepareok;
            comlivreok = unComlivreok;
            leClient = unClient;
        }

        public int getcomnum()
        {
            return comnum;
        }

        public string getcomdateh()
        {
            return comdateh;
        }

        public string getcomdatehretrait()
        {
            return comdatehretrait;
        }

        public int getcomprepareok()
        {
            return comprepareok;
        }

        public int getcomlivreok()
        {
            return comlivreok;
        }

        public Client getclient()
        {
            return leClient;
        }

    }
}
