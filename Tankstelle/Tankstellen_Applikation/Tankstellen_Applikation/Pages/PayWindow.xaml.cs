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
using System.Windows.Shapes;
using Tankstellen_Applikation.ViewModels;

namespace Tankstellen_Applikation.Pages
{
    /// <summary>
    /// Interaktionslogik für PayWindow.xaml
    /// </summary>
    public partial class PayWindow : Window
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

        public PayWindow(PayViewModel pvm)
        {
            Model = pvm;
            InitializeComponent();
        }
    }
}
