﻿using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Xml.Linq;
using System.Xml;

namespace Foodvaultwpf
{
    /// <summary>
    /// Interaktionslogik für NewRec.xaml
    /// </summary>
    public partial class NewRec : Window
    {
        public NewRec()
        {
            InitializeComponent();
        }
        List<Inst_Ing> ingsList = new List<Inst_Ing>();

        private void recImpWriteBtn_Click(object sender, RoutedEventArgs e)
        {
            RecipeList.recIDCount++;
            string recImpName = recImpNameTB.Text;
            string recImpPrep = recImpPrepTB.Text;
            XDocument xDocument = XDocument.Load("Recipes.xml");
            XElement root = xDocument.Element("Recipes");
            XElement rec = new XElement("Recipe");
            root.Add(rec);
            rec.SetAttributeValue("recID", RecipeList.recIDCount.ToString());
            XElement recName = new XElement("Name", recImpName);
            rec.Add(recName);
            XElement recCal = new XElement("Calories", "0");
            rec.Add(recCal);
            XElement recTime = new XElement("Time", "0");
            rec.Add(recTime);
            XElement recIngs = new XElement("Ingredients");
            rec.Add(recIngs);
            foreach (Inst_Ing ing in ingsList)
            {
                recIngs.Add(new XElement("Ingredient",
                                 new XElement("Amount", ing.Amount),
                                 new XElement("Name", ing.Name)));
            }
            XElement recPrep = new XElement("Preparation", recImpPrep);
            rec.Add(recPrep);
            xDocument.Save("Recipes.xml"); //erzeugt neuen XML-Eintrag für das Rezept und schreibt diesen in die Rezeptdatei

            Recipe newRec = new Recipe(RecipeList.recIDCount, recImpName, recImpPrep, ingsList);
            RecipeList.AddRecipe(newRec);
            RecipeList.UpdateIngConnections(IngredientsList.ingsList, xDocument, newRec); //erzeugt neues Recipe-Objekt und fügt es der Liste hinzu
            this.Close();
        }

        private void recImpNameTB_TextChanged(object sender, TextChangedEventArgs e)
        {
            recImpNameTB.Text = recImpNameTB.Text.Trim();
        }

        private void recImpUriBtn_Click(object sender, RoutedEventArgs e)
        {
            if (recImpUriBox.Text != "")
            {
                try {
                    if (recImpUriBox.Text.Contains("chefkoch.de"))
                    {
                        string recImpUri = recImpUriBox.Text;
                        HtmlWeb recImpSite = new HtmlWeb();
                        HtmlDocument doc = recImpSite.Load(recImpUri); 
                        var nodeRecName = doc.DocumentNode.SelectSingleNode("//h1[@class='page-title fn']");
                        if (nodeRecName != null)
                        {
                            recImpNameTB.Text = nodeRecName.InnerText.Trim();
                        }
                        var nodeRecIngs = doc.DocumentNode.SelectSingleNode("//table[@class='incredients']");

                        if (nodeRecIngs != null)
                        {
                            ingsList.Clear();
                            foreach (HtmlNode row in nodeRecIngs.SelectNodes("tr"))
                            {
                                
                                Inst_Ing data = new Inst_Ing (row.SelectSingleNode("td[@class='amount']").InnerText.Trim().Replace("&nbsp;"," "), row.SelectSingleNode("td[@class='name']").InnerText.Trim() );
                                ingsList.Add(data);
                            }
                            recImpIngsDG.ItemsSource = ingsList;
                        }
                        var nodeRecPrep = doc.DocumentNode.SelectSingleNode("//div[@id='rezept-zubereitung']");
                        if (nodeRecPrep != null)
                        {
                            recImpPrepTB.Text = nodeRecPrep.InnerText.Trim();
                        }
                    }
                } catch(Exception ex) { recImpPrepTB.Text = ex.Message; }
            }

        }
    }
    
}