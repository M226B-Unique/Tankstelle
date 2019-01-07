using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Tankstellen_Applikation.Pages;

namespace Tankstellen_Applikation.ViewModels
{
    public class MainViewModel
    {
        private Container petrolContainer;
        private Container dieselContainer;
        private Container truckDieselContainer;

        public List<Container> Containers { get; set; }

        public MainViewModel()
        {
            Containers.Add(petrolContainer);
            Containers.Add(dieselContainer);
            Containers.Add(truckDieselContainer);
        }
    }
}
