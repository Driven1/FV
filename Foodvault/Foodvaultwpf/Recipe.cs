using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Xml.Linq;

namespace Foodvaultwpf
{
    public class Recipe
    {
        private string nAME;
        private int cALORIES;
        private int tTC; // time to cook
        private float cOST;
        private string pREP;
        public List<Inst_Ing> INGS = new List<Inst_Ing>();

        public string NAME
        {
            get
            {
                return nAME;
            }

            set
            {
                nAME = value;
            }
        }

        public int CALORIES
        {
            get
            {
                return cALORIES;
            }

            set
            {
                cALORIES = value;
            }
        }

        public int TTC
        {
            get
            {
                return tTC;
            }

            set
            {
                tTC = value;
            }
        }

        public float COST
        {
            get
            {
                return cOST;
            }

            set
            {
                cOST = value;
            }
        }

        public string PREP
        {
            get
            {
                return pREP;
            }

            set
            {
                pREP = value;
            }
        }


        public Recipe(string name, string prep, List<Inst_Ing> ings)
        {
            NAME = name;
            PREP = prep;
            INGS = ings;
        }

        public Recipe(string name, string prep, List<Inst_Ing> ings, int cal)
        {
            NAME = name;
            PREP = prep;
            INGS = ings;
            CALORIES = cal;
        }

        public Recipe(string name, string prep, List<Inst_Ing> ings, int cal, int ttc)
        {
            NAME = name;
            PREP = prep;
            INGS = ings;
            CALORIES = cal;
            TTC = ttc;
        }

        public Recipe(string name, string prep, List<Inst_Ing> ings, int cal, int ttc, float cost)
        {
            NAME = name;
            PREP = prep;
            INGS = ings;
            CALORIES = cal;
            TTC = ttc;
            COST = cost;
        }
    }
}