using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Foodvaultwpf
{
    public class IngredientsList
    {
        private List<Ingredient> ingsList = new List<Ingredient>();

        public void FillMyList()
        {
            XDocument recXDoc = XDocument.Load("Ingredients.xml");  // XML-Dokument lesen
            ingsList.Clear();
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
            
        }

        public Ingredient FindIng(Inst_Ing ing)
        {
            if (ing.ingID != 0)
            {
                Ingredient result = ingsList.Find(item => item.IngID == ing.ingID);
                return result;
            }
            else
            {
                Ingredient result = ingsList.Find(item => item.name == ing.Name);
                return result;
            }

        }
    }
}
