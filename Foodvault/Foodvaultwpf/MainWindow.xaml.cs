using System.Windows;
using System.Windows.Controls;
using System.Data;

namespace Foodvaultwpf
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    { 

        public MainWindow()
        {
            InitializeComponent();
            new SplashWindow().ShowDialog();
        }

        private void recSortBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            recListBox.ItemsSource = RecipeList.SortMyList(recListBox.Items, recSortBox.SelectedIndex);
        }

        private void recListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                recCalText.Text = ((Recipe)recListBox.SelectedItem).CALORIES.ToString() + " kcal";
                recTimeText.Text = ((Recipe)recListBox.SelectedItem).TTC.ToString() + " min.";
                recPrepTBlock.Text = ((Recipe)recListBox.SelectedItem).PREP.ToString();
                recIngDGrid.ItemsSource = ((Recipe)recListBox.SelectedItem).INGS;
                
            }
            catch
            {
                recCalText.Text = "";
                recTimeText.Text = "";
                recPrepTBlock.Text = "";
                recIngDGrid.ItemsSource = "";
            }
        }

        private void recSearchBtn_Click(object sender, RoutedEventArgs e)
        {
            recListBox.ItemsSource = (RecipeList.SearchMyList(recSearchBox.Text));
            recListBox.DisplayMemberPath = "NAME";
        }

        private void recOpenImportBtn_Click(object sender, RoutedEventArgs e)
        {
            NewRec win = new NewRec();
            win.Show();
        }

        private void recIngDGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
        }

        private void ingSearchBtn_Click(object sender, RoutedEventArgs e)
        {
            NewIng newing = new NewIng();
            newing.Show();
        }
    }
}