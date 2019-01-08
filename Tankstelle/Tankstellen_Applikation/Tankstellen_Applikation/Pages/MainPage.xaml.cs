using BusinessLogic;
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
using Tankstellen_Applikation.ViewModels;

namespace Tankstellen_Applikation.Pages
{
    /// <summary>
    /// Interaktionslogik für MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public GaspumpViewModel Model
        {
            get
            {
                return (GaspumpViewModel)DataContext;
            }
            set
            {
                DataContext = value;
            }
        }

        GasPump gasp;
        public MainPage()
        {
            gasp = new GasPump();
            Model = new GaspumpViewModel();
            InitializeComponent();
            MainFrame.Content = new ShopPage();

        }

        private void Säule_01_Einfahren_Click(object sender, RoutedEventArgs e)
        {
            if (gasp.Occupied == true)
            {
                MessageBox.Show("Ist besetzt. Warten Sie");
            }

            gasp.Occupied = true;
            Model.EinfahrenIsEnabled = false;
            Model.AusfahrenIsEnabled = true;
            Model.DieselIsEnabled = true;
            Model.PetrolIsEnabled = true;
            Model.TruckdieselIsEnabled = true;
            Model.TankIsEnabled = false;
        }

        private void Säule_01_Ausfahren_Click(object sender, RoutedEventArgs e)
        {
            Model.ClearGasPump();
        }

        private void Petrol_btn_Click(object sender, RoutedEventArgs e)
        {
            Model.FuelType = Fuel.Petrol;
            Petrol_btn.Background = Brushes.Green;
            Diesel_btn.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFDDDDDD"));
            TruckD_btn.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFDDDDDD"));
            Model.TankIsEnabled = true;
            Model.OneTapIsOccupied = true;
        }

        private void Diesel_btn_Click(object sender, RoutedEventArgs e)
        {
            Model.FuelType = Fuel.Diesel;
            Diesel_btn.Background = Brushes.Green;
            Petrol_btn.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFDDDDDD"));
            TruckD_btn.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFDDDDDD"));
            Model.TankIsEnabled = true;
            Model.OneTapIsOccupied = true;
        }

        private void TruckD_btn_Click(object sender, RoutedEventArgs e)
        {
            Model.FuelType = Fuel.TruckDiesel;
            TruckD_btn.Background = Brushes.Green;
            Diesel_btn.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFDDDDDD"));
            Petrol_btn.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFDDDDDD"));
            Model.TankIsEnabled = true;
            Model.OneTapIsOccupied = true;
        }

        private void Tanken_btn_Click(object sender, RoutedEventArgs e)
        {
            Model.PetrolIsEnabled = false;
            Model.DieselIsEnabled = false;
            Model.TruckdieselIsEnabled = false;
            if (Model.IsFueling == false)
            {
                Tanken_btn.Content = "Stoppen";
                Model.StartFuelingInBackground();
                Model.IsFueling = true;
            }
            else
            {
                if ((string)Tanken_btn.Content == "Stoppen")
                {
                    Tanken_btn.Content = "Zahlen";

                }
                Tanken_btn.Content = "Tanken";
                Model.IsFueling = false;
            }
        }
    }
}
