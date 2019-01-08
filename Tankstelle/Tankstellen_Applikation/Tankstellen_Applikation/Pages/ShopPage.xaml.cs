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
    /// Interaktionslogik für ShopPage.xaml
    /// </summary>
    public partial class ShopPage : Page
    {
        public PayViewModel Model
        {
            get
            {
                return (PayViewModel)DataContext;
            }
            set
            {
                DataContext = value;
            }
        }

        public ShopPage()
        {
            Model = new PayViewModel();
            InitializeComponent();
        }

        private void btn_pay_Click(object sender, RoutedEventArgs e)
        {
            PayWindow payWindow = new PayWindow(Model);      //Create instance of pay window
            payWindow.Show();                           //Open window
        }

        private void btn_buySnickers_Click(object sender, RoutedEventArgs e)
        {
            Product product = new Product();
            product.Name = "Snickers";
            product.Price = 2.5f;
            Model.CustomerReceipt.Products.Add(product);
            Model.GetAllInformationsIntoTheViewProperties();
        }

        private void btn_buyBounty_Click(object sender, RoutedEventArgs e)
        {
            Product product = new Product();
            product.Name = "Bounty";
            product.Price = 2.25f;
            Model.CustomerReceipt.Products.Add(product);
            Model.GetAllInformationsIntoTheViewProperties();
        }

        private void btn_buyMars_Click(object sender, RoutedEventArgs e)
        {
            Product product = new Product();
            product.Name = "Mars";
            product.Price = 2.75f;
            Model.CustomerReceipt.Products.Add(product);
            Model.GetAllInformationsIntoTheViewProperties();
        }
    }
}
