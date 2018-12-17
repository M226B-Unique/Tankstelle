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
using Tankstellen_Applikation.Pages;

namespace Tankstellen_Applikation
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            MainPage mainPage = new MainPage();
            MainPage mainPage1 = new MainPage();
            MainPage mainPage2 = new MainPage();

            InitializeComponent();
            
            Zapfsäule_0.Content = mainPage;
            Zapfsäule_1.Content = mainPage1;
            Zapfsäule_2.Content = mainPage2;
        }

        
    }
}
