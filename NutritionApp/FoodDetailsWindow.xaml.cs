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

namespace NutritionApp
{
    /// <summary>
    /// Interaction logic for FoodDetailsWindow.xaml
    /// </summary>
    public partial class FoodDetailsWindow : Window
    {
        public FoodDetailsWindow(Food currentFood)
        {
            InitializeComponent();
            //assign all the labels
            LblFoodName.Content = currentFood.FoodName.ToString();
            LblFoodType.Content = currentFood.FoodType.ToString();
            LblServSize.Content = currentFood.ServingSize.ToString();
            LblWeight.Content = currentFood.Weight.ToString();
            LblPercent.Content = currentFood.PercentWater.ToString();
            LblCal.Content = currentFood.Energy.ToString();
            LblProtein.Content = currentFood.Protein.ToString();
            LblCarb.Content = currentFood.Carb.ToString();
            LblFiber.Content = currentFood.Fiber.ToString();
            LblChol.Content = currentFood.Cholesterol.ToString();
            
            LblTotalFat.Content = currentFood.TotalFat.ToString();
            LblSat.Content = currentFood.SatFat.ToString();
            LblMono.Content = currentFood.MonFat.ToString();
            LblPoly.Content = currentFood.PolyFat.ToString();

            LblCalcium.Content = currentFood.Calcium.ToString();
            LblIron.Content = currentFood.Iron.ToString();
            LblMag.Content = currentFood.Magnesium.ToString();
            LblSodium.Content = currentFood.Sodium.ToString();
            LblPhos.Content = currentFood.Phos.ToString();
            LblCap.Content = currentFood.Cap.ToString();

            LblPot.Content = currentFood.Potassium.ToString();
            LblZinc.Content = currentFood.Zinc.ToString();
            LblNiac.Content = currentFood.Niacin.ToString();
            LblThia.Content = currentFood.Thiamin.ToString();
            LblRibo.Content = currentFood.Ribo.ToString();
            LblVitA.Content = currentFood.VitA.ToString();
            LblVitB.Content = currentFood.VitB.ToString();
            LblVitC.Content = currentFood.VitC.ToString();




        }
        /// <summary>
        /// closes the modal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
