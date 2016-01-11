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
                                        )); // erzeugt für jeden Ingredient-Knoten ein objekt der Klasse Ingredient und fügt es der liste hinzu
            }
            ingIDCount = ingsList.MaxObject(item => item.IngID).IngID; // setzt den id-zähler auf den höchsten Wert, der unter allen Objekten in der Liste bereits vorhanden ist
            
        }

        public static Ingredient FindIng(Inst_Ing ing, List<Ingredient> ingsInstList) // sucht in der angegebenen Liste eine Zutat, deren ID oder Name übereinstimmen mit der angegebenen Rezeptzutat
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
