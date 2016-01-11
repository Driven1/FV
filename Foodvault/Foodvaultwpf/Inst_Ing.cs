using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Foodvaultwpf
{
    public class Inst_Ing
    {
        public string Amount { get; set; }
        public string Name { get; set; }
        public float Calories { get; set; }
        public float Protein { get; set; }
        public float Fat { get; set; }
        public float Carbs { get; set; }
        private string tooltip;
        public bool NutActive { get; set; }
        public int ingID { get; set;}
        public string Tooltip
        {
            get
            {
                try
                {
                    tooltip = "Nährwerte pro 100g:" + Environment.NewLine +
                              "kCal: " + Calories + Environment.NewLine +
                              "Eiweiss: " + Protein + Environment.NewLine +
                              "Fett: " + Fat + Environment.NewLine +
                              "Kohlenhydrate: " + Carbs;
                }
                catch
                {
                    tooltip = "Nährwerte pro 100g:" + Environment.NewLine +
                              "kCal: möp " + Environment.NewLine +
                              "Eiweiss: möp" + Environment.NewLine +
                              "Fett: möp" + Environment.NewLine +
                              "Kohlenhydrate: möp";
                }
                return tooltip;
            }

            set
            {
                tooltip = value;
            }
        }

        public Inst_Ing (string am, string na)
        {
            Amount = am;
            Name = na;
            NutActive = false;
            
        }

        public Inst_Ing (string am, string na, int id)
        {
            Amount = am;
            Name = na;
            ingID = id;
            NutActive = false;
        }

        public void setNutritionals (Ingredient ing) //kopiert die Nährwerte der angegebenen Zutat in die Rezeptzutat und markiert diese als gefüllt, damit der TemplateSelector anspringt.
        {
            Calories = ing.calories;
            Protein = ing.protein;
            Fat = ing.fat;
            Carbs = ing.carbs;
            NutActive = true;
            if (ingID == 0)
            {
                ingID = ing.IngID;


            }
            
        }
    }
}
