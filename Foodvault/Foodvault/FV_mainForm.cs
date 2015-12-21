using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Linq;
using System.Collections;
using System.Web.UI.WebControls;

namespace Foodvault
{
    public partial class FV_mainForm : Form
    {
        public FV_mainForm()
        {
            InitializeComponent();
            Fillmylist();

        }

        XDocument recXDoc = XDocument.Load("Recipes.xml");  // XML-Dokument lesen
        List<recipe> recList = new List<recipe>(); // Liste für Objekte der Klasse recipe anlegen

        public void Fillmylist()
        {
            foreach (XElement recipe in recXDoc.Descendants("Recipe"))
            {
                recList.Add(new recipe
                {
                    NAME = recipe.Element("Name").Value,
                    CALORIES = Convert.ToInt32(recipe.Element("Calories").Value),
                    TTC = Convert.ToInt32(recipe.Element("Time").Value)
                }); // erzeugt für jeden Recipe-Knoten ein objekt der Klasse recipe und fügt es der liste hinzu
            }
            listBox1.DataSource = recList;
            listBox1.DisplayMember = "NAME"; //Eigenschaft des Objekts die angezeigt wird
            listBox1.ValueMember = "CALORIES"; //Eigenschaft des Objekts die als Wert gesetzt wird

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string calText = listBox1.SelectedItem.ToString();
                //string calText = (listBox1.SelectedItem as DataRowView)["CALORIES"].ToString();
                calLabel.Text = calText;
            }
            catch
            {
            }
        }

        private void SortrecList(object sender, EventArgs e) // wird ausgelöst sobald der selectedindex in der combobox1 verändert wird
        {
            List<recipe> recListSort = new List<recipe>();
            recListSort.Clear();
            foreach (recipe rec in listBox1.Items)
            {
                recListSort.Add(rec);
            }
            switch (comboBox1.SelectedIndex)
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
            listBox1.DataSource = null;
            listBox1.Items.Clear();
            listBox1.DataSource = recListSort;
            listBox1.DisplayMember = "NAME";
            listBox1.ValueMember = "CALORIES";
        }



    }

    public partial class recipe
    {
        public String NAME { get; set; }
        public int CALORIES { get; set; }
        public int TTC { get; set; } // time to cook
        public int COST{ get; set; }

    }

}
