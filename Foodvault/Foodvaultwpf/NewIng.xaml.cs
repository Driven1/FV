using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xml.Linq;
using System.Xml;

namespace Foodvaultwpf
{
    /// <summary>
    /// Interaction logic for NewIng.xaml
    /// </summary>
    public partial class NewIng : Window
    {
        public NewIng()
        {
            InitializeComponent();
        }

        private void ingImpBtn_Click(object sender, RoutedEventArgs e)
        {
            IngredientsList.ingIDCount++;
            XDocument xDocument = XDocument.Load("Ingredients.xml");
            XElement root = xDocument.Element("Ingredients");
            XElement ing = new XElement("Ingredient");
            root.Add(ing);
            ing.SetAttributeValue("ingID", IngredientsList.ingIDCount.ToString());
            XElement ingName = new XElement("Name", ingImpNameTB.Text);
            ing.Add(ingName);
            XElement ingCal = new XElement("Calories", ingImpCalTB.Text);
            ing.Add(ingCal);
            XElement ingProt = new XElement("Protein", ingImpProtTB.Text);
            ing.Add(ingProt);
            XElement ingFat = new XElement("Fat", ingImpFatTB.Text);
            ing.Add(ingFat);
            XElement ingCarbs = new XElement("Carbs", ingImpCarbTB.Text);
            ing.Add(ingCarbs);

            xDocument.Save("Ingredients.xml");
            IngredientsList.ingsList.Add(new Ingredient(IngredientsList.ingIDCount, 
                                                        ingImpNameTB.Text, 
                                                        float.Parse(ingImpCalTB.Text, System.Globalization.CultureInfo.InvariantCulture), 
                                                        float.Parse(ingImpProtTB.Text, System.Globalization.CultureInfo.InvariantCulture), 
                                                        float.Parse(ingImpFatTB.Text, System.Globalization.CultureInfo.InvariantCulture), 
                                                        float.Parse(ingImpCarbTB.Text, System.Globalization.CultureInfo.InvariantCulture)));

            RecipeList.UpdateIngConnections(IngredientsList.ingsList, XDocument.Load("Recipes.xml"));
            this.Close();
        }
    }
}
