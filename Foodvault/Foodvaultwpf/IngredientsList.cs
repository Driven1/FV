using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Foodvaultwpf
{
    public static class IngredientsList
    {
        public static List<Ingredient> ingsList = new List<Ingredient>();
        public static int ingIDCount { get; set; }

        public static void FillMyList()
        {
            XDocument recXDoc = XDocument.Load("Ingredients.xml");  // XML-Dokument lesen
            foreach (XElement recipe in recXDoc.Descendants("Ingredient"))
            {
                ingsList.Add(new Ingredient(
                                        Convert.ToInt32(recipe.Attribute("ingID").Value),
                                        recipe.Element("Name").Value,
                                        float.Parse(recipe.Element("Calories").Value, System.Globalization.CultureInfo.InvariantCulture),
                                        float.Parse(recipe.Element("Protein").Value, System.Globalization.CultureInfo.InvariantCulture),
                                        float.Parse(recipe.Element("Fat").Value, System.Globalization.CultureInfo.InvariantCulture),
                                        float.Parse(recipe.Element("Carbs").Value, System.Globalization.CultureInfo.InvariantCulture)
                                        )); // erzeugt für jeden Recipe-Knoten ein objekt der Klasse recipe und fügt es der liste hinzu
            }
            ingIDCount = ingsList.MaxObject(item => item.IngID).IngID; 
            
        }

        public static Ingredient FindIng(Inst_Ing ing, List<Ingredient> ingsInstList)
        {
            if (ing.ingID != 0)
            {
                Ingredient result = ingsInstList.Find(item => item.IngID == ing.ingID);
                return result;
            }
            else
            {
                Ingredient result = ingsInstList.Find(item => item.name == ing.Name);
                return result;
            }

        }
    }
}
