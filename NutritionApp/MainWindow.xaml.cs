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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace NutritionApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Dictionary<string, Food> foodDict = new Dictionary<string, Food>();
        public MainWindow()
        {
            InitializeComponent();
            LoadFoods();
        }
        /// <summary>
        /// read the foods from a text file and add the foods to a dictionary and the combobox
        /// </summary>
        private void LoadFoods()
        {
            StreamReader inputfile;
            try
            {
                inputfile = File.OpenText("nutrition.txt");
                inputfile.ReadLine();
                while (!inputfile.EndOfStream)
                {
                    string[] foodArray = inputfile.ReadLine().Split('\t');
                    Food currentFood = new Food(foodArray);
                    foodDict.Add(currentFood.FoodName, currentFood);
                    CbFoods.Items.Add(currentFood.FoodName);

                }
                inputfile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDetails_Click(object sender, RoutedEventArgs e)
        {
            if (CbFoods.SelectedIndex != -1)
            {
                string selectedFood = CbFoods.SelectedItem.ToString();
                if (foodDict.TryGetValue(selectedFood, out Food currentFood))
                {
                    FoodDetailsWindow detailsWindow = new FoodDetailsWindow(currentFood);

                    detailsWindow.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Food not found.");
                }
            }
            else
            {
                MessageBox.Show("Please select a food.");
            }
        }
    }
}
