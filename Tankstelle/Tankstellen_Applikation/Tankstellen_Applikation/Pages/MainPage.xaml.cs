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
            Model.IsOccupied = true;
            Model.EinfahrenIsEnabled = false;
            Model.AusfahrenIsEnabled = true;
        }

        private void Säule_01_Ausfahren_Click(object sender, RoutedEventArgs e)
        {
            Model.SetToZero();
            if (gasp.Occupied == true)
            {
                gasp.Occupied = false;
                Model.IsOccupied = false;
                Model.EinfahrenIsEnabled = true;

                Model.AusfahrenIsEnabled = false;
            }
        }

        private void Benzin_btn_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Super_btn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Diesel_btn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Tanken_btn_Click(object sender, RoutedEventArgs e)
        {
            if (Model.IsFueling == false)
            {
                Tanken_btn.Content = "Stoppen";
                Model.StartFuelingInBackground();
                Model.IsFueling = true;
                Model.FuelTypeIsEnabled = false;
            }
            else
            {
                if ((string)Tanken_btn.Content == "Stoppen")
                {
                    Tanken_btn.Content = "Zahlen";

                }
                Tanken_btn.Content = "Tanken";
                Model.IsFueling = false;
                Model.FuelTypeIsEnabled = true;
            }
        }
    }
}
