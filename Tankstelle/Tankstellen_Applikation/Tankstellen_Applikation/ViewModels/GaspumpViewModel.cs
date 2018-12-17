using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tankstellen_Applikation.ViewModels
{
    public class GaspumpViewModel : INotifyPropertyChanged
    {
        private const float priceForPetrol = 1.43f;

        private bool fuelTypeIsEnabled = true;
        public bool FuelTypeIsEnabled
        {
            get
            {
                return fuelTypeIsEnabled;
            }
            set
            {
                fuelTypeIsEnabled = value;
                RaisePropertyChanged(nameof(FuelTypeIsEnabled));
            }
        }

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
                RaisePropertyChanged(nameof(FuelInLiterAsString));
                RaisePropertyChanged(nameof(GetanktPreisAsString));
            }
        }

        private bool isOccupied = false;
        public bool IsOccupied
        {
            get
            {
                return isOccupied;
            }
            set
            {
                isOccupied = value;
                RaisePropertyChanged(nameof(IsOccupied));
            }
        }

        private bool einfahrenIsEnabled = true;
        public bool EinfahrenIsEnabled
        {
            get
            {
                return einfahrenIsEnabled;
            }
            set
            {
                einfahrenIsEnabled = value;
                RaisePropertyChanged(nameof(EinfahrenIsEnabled));
            }
        }

        private bool ausfahrenIsEnabled = false;
        public bool AusfahrenIsEnabled
        {
            get
            {
                if (IsFueling == true)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            set
            {
                ausfahrenIsEnabled = value;
                RaisePropertyChanged(nameof(AusfahrenIsEnabled));
            }
        }

        private string fuelInLiterAsString;
        public string FuelInLiterAsString
        {
            get
            {
                return (string.Format("{0:#.00}", FuelInLiters) + " L");
            }
            set
            {
                fuelInLiterAsString = value;
                RaisePropertyChanged(nameof(FuelInLiterAsString));
            }
        }

        private string getanktPreisAsString;

        public string GetanktPreisAsString
        {
            get
            {
                return (string.Format("{0:#.00}", (FuelInLiters * priceForPetrol)) + " CHF");
            }
            set
            {
                getanktPreisAsString = value;
                RaisePropertyChanged(nameof(GetanktPreisAsString));
            }
        }

        private bool isFueling = false;

        public bool IsFueling
        {
            get
            {
                return isFueling;
            }
            set
            {
                isFueling = value;
                RaisePropertyChanged(nameof(IsFueling));
                RaisePropertyChanged(nameof(AusfahrenIsEnabled));
            }
        }

        public void StartFuelingInBackground()
        {
            Task.Run(() => StartFueling());
        }

        public void StartFueling()
        {
            while (IsFueling == true)
            {
                FuelInLiters += 0.02;
                Thread.Sleep(50);
            }
        }

        public void SetToZero()
        {
            FuelInLiters = 0;
        }


        private void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
