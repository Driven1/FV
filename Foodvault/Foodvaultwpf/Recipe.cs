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
        public int recID { get; set;}

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


        public Recipe(int recid, string name, string prep, List<Inst_Ing> ings)
        {
            NAME = name;
            PREP = prep;
            INGS = ings;
            recID = recid;
        }

        public Recipe(int recid, string name, string prep, List<Inst_Ing> ings, int cal)
        {
            NAME = name;
            PREP = prep;
            INGS = ings;
            CALORIES = cal;
            recID = recid;
        }

        public Recipe(int recid, string name, string prep, List<Inst_Ing> ings, int cal, int ttc)
        {
            NAME = name;
            PREP = prep;
            INGS = ings;
            CALORIES = cal;
            TTC = ttc;
            recID = recid;
        }

        public Recipe(int recid, string name, string prep, List<Inst_Ing> ings, int cal, int ttc, float cost)
        {
            NAME = name;
            PREP = prep;
            INGS = ings;
            CALORIES = cal;
            TTC = ttc;
            COST = cost;
            recID = recid;
        }

        public void RecUpdate(XDocument xmlFile)
        {
            foreach (Inst_Ing ing in INGS)
            {
                var query = from c in xmlFile.Elements("Recipes").Elements("Recipe").Elements("Ingredients").Elements("Ingredient").
                            Where(c => c.Element("Name").Value == ing.Name && (c.Attribute("ingID") == null || c.Attribute("ingID").Value == "0" ))
                            select c;

                foreach (XElement hit in query)
                {
                    hit.SetAttributeValue("ingID",ing.ingID.ToString());
                }
            }
            xmlFile.Save("Recipes.xml");
        }
    }
}