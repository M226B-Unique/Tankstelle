using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Container : INotifyPropertyChanged
    {
        private Fuel fuelType;

        private double currentFuelValue;

        public double FuelMax { get; set; } = 15000;       //In Liter

        public Fuel FuelType { get; set; }

        public double CurrentFuelValue
        {
            get
            {
                return currentFuelValue;
            }
            set
            {
                currentFuelValue = value;
                RaisePropertyChanged(nameof(CurrentFuelValue));
            }
        }

        private void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
