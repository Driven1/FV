using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foodvaultwpf
{
    public class Ingredient
    {
        private string Name;
        private float Calories;
        private float Protein;
        private float Fat;
        private float Carbs;

        public Ingredient (string na, float cal, float pro, float fa, float ca)
        {
            Name = na;
            Calories = cal;
            Protein = pro;
            Fat = fa;
            Carbs = ca;

        }
        public string name
        {
            get
            {
                return Name;
            }

            set
            {
                Name = value;
            }
        }

        public float protein
        {
            get
            {
                return Protein;
            }

            set
            {
                Protein = value;
            }
        }

        public float fat
        {
            get
            {
                return Fat;
            }

            set
            {
                Fat = value;
            }
        }

        public float carbs
        {
            get
            {
                return Carbs;
            }

            set
            {
                Carbs = value;
            }
        }

        public float calories
        {
            get
            {
                return Calories;
            }

            set
            {
                Calories = value;
            }
        }
    }
}
