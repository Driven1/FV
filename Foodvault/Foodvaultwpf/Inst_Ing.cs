using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        private bool nutIsSet = false;
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
            
        }

        public void setNutritionals (Ingredient ing)
        {
            Name = ing.name;
            Calories = ing.calories;
            Protein = ing.protein;
            Fat = ing.fat;
            Carbs = ing.carbs;
            nutIsSet = true;
            
        }
    }
}
