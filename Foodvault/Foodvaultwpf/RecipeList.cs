using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;
using System.Xml.Linq;

namespace Foodvaultwpf
{
    public static class RecipeList
    {
        private static List<Recipe> recList = new List<Recipe>();
        public static int recIDCount { get; set;}

        public static void LoadRecipes(List<Ingredient> ingInstLis)
        {
            XDocument recXDoc = XDocument.Load("Recipes.xml");  // XML-Dokument lesen
            foreach (XElement recipe in recXDoc.Descendants("Recipe"))
            {
                recList.Add(new Recipe(
                                        Convert.ToInt32(recipe.Attribute("recID").Value),
                                        recipe.Element("Name").Value,
                                        recipe.Element("Preparation").Value,
                                        ReadIngs(recipe.Element("Ingredients")),
                                        Convert.ToInt32(recipe.Element("Calories").Value),
                                        Convert.ToInt32(recipe.Element("Time").Value))); // erzeugt für jeden Recipe-Knoten ein objekt der Klasse recipe und fügt es der liste hinzu

            }
            UpdateIngConnections(ingInstLis, recXDoc);
            
            recIDCount = recList.MaxObject(item => item.recID).recID;
        }
        public static void AddRecipe(Recipe rec)
        {
            recList.Add(rec);
        }

        public static List<Recipe> SortMyList(ItemCollection source, int index)
        {
            List<Recipe> recListSort = new List<Recipe>();
            recListSort.Clear();
            foreach (Recipe rec in source)
            {
                recListSort.Add(rec);
            }
            switch (index)
            {
                case 0:                     // sort Kalorien aufsteigend
                    recListSort = recListSort.OrderBy(item => item.CALORIES).ToList();

                    break;

                case 1:                     // sort Kalorien absteigend
                    recListSort = recListSort.OrderByDescending(item => item.CALORIES).ToList();
                    break;

                case 2:                     // sort Zeitaufwand aufsteigend
                    recListSort = recListSort.OrderBy(item => item.TTC).ToList();
                    break;

                case 3:                     // sort Zeitaufwand absteigend
                    recListSort = recListSort.OrderByDescending(item => item.TTC).ToList();
                    break;

                case 4:                     // sort Kosten aufsteigend
                    break;

                case 5:                     // sort Kosten absteigend
                    break;

                default:
                    break;
            }
            return recListSort;
        }

        public static List<Recipe> SearchMyList(string searchItem)
        {
            List<Recipe> recListSearch = new List<Recipe>();
            foreach (Recipe rec in recList)
            {
                if (rec.NAME.Contains(searchItem))
                {
                    recListSearch.Add(rec);
                }
            }
            return recListSearch;
        }

        public static List<Inst_Ing> ReadIngs(XElement xe)
        {
            List<Inst_Ing> inst_List = new List<Inst_Ing>();
            foreach (XElement ing in xe.Descendants("Ingredient"))
            {
                if (ing.Attribute("ingID") != null)
                {
                    inst_List.Add(new Inst_Ing(ing.Element("Amount").Value,
                                               ing.Element("Name").Value,
                                               Convert.ToInt32(ing.Attribute("ingID").Value)));
                }
                else
                {
                    inst_List.Add(new Inst_Ing(ing.Element("Amount").Value,
                                               ing.Element("Name").Value));
                }
            }
            return inst_List;
        }

        public static void UpdateIngConnections(List<Ingredient> ingInstLis, XDocument recXDoc)
        {
            foreach (Recipe rec in recList)
            {
                foreach (Inst_Ing ing in rec.INGS)
                {
                    try
                    {
                        ing.setNutritionals(IngredientsList.FindIng(ing, ingInstLis));
                    }
                    catch
                    {

                    }
                }
                rec.RecUpdate(recXDoc);
            }
        }
    }
}