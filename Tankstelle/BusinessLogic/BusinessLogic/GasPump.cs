using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class GasPump : INotifyPropertyChanged
    {
        public List<Tap> Taps { get; set; } = new List<Tap>();

        private double fuelInLiters;

        public double FuelInLiters
        {
            get
            {
                return fuelInLiters;
            }
            set
            {
                fuelInLiters = value;
                RaisePropertyChanged(nameof(FuelInLiters));
            }
        }

        public float Price { get; set; }

        public bool Occupied { get; set; }

        public Tap TakenTap { get; set; }

        public bool IsFueling { get; set; } = false;

        public GasPump()
        {
            Tap petrol = new Tap();
            petrol.FuelType = Fuel.Petrol;
            petrol.Number = 1;
            Tap superBenzin = new Tap();
            superBenzin.FuelType = Fuel.Super_Petrol;
            superBenzin.Number = 2; 
            Tap diesel = new Tap();
            diesel.FuelType = Fuel.Diesel;
            diesel.Number = 3;

            Taps.Add(petrol);
            Taps.Add(superBenzin);
            Taps.Add(diesel);
            Occupied = false;
            IsFueling = true;
        }

        public void StartFueling()
        {
            while(IsFueling == true)
            {
                FuelInLiters += 0.200;
                Thread.Sleep(200);
            }
        }

        private void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
