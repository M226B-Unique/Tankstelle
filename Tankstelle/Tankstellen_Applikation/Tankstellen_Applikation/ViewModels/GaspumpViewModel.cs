using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BusinessLogic;

namespace Tankstellen_Applikation.ViewModels
{
    public class GaspumpViewModel : INotifyPropertyChanged
    {
        private const float priceForPetrol = 1.43f;

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
            }
        }

        private double fuelPrice;
        public double FuelPrice
        {
            get
            {
                return fuelPrice;
            }
            set
            {
                fuelPrice = value;
                RaisePropertyChanged(nameof(FuelPrice));
                RaisePropertyChanged(nameof(TankedPriceAsString));
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
                return ausfahrenIsEnabled;
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

        private string tankedPriceAsString;
        public string TankedPriceAsString
        {
            get
            {
                return (string.Format("{0:#.00}", (FuelPrice)) + " CHF");
            }
            set
            {
                tankedPriceAsString = value;
                RaisePropertyChanged(nameof(TankedPriceAsString));
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

        private bool petrolIsEnabled = false;
        public bool PetrolIsEnabled
        {
            get
            {
                return petrolIsEnabled;
            }
            set
            {
                petrolIsEnabled = value;
                RaisePropertyChanged(nameof(PetrolIsEnabled));
            }
        }

        private bool dieselIsEnabled = false;
        public bool DieselIsEnabled
        {
            get
            {
                return dieselIsEnabled;
            }
            set
            {
                dieselIsEnabled = value;
                RaisePropertyChanged(nameof(DieselIsEnabled));
            }
        }

        private bool truckDieselIsEnabled = false;
        public bool TruckdieselIsEnabled
        {
            get
            {
                return truckDieselIsEnabled;
            }
            set
            {
                truckDieselIsEnabled = value;
                RaisePropertyChanged(nameof(TruckdieselIsEnabled));
            }
        }

        private Fuel fuelType;
        public Fuel FuelType
        {
            get
            {
                return fuelType;
            }
            set
            {
                fuelType = value;
                RaisePropertyChanged(nameof(FuelType));
            }
        }

        private bool tankIsEnabled = false;
        public bool TankIsEnabled
        {
            get
            {
                return tankIsEnabled;
            }
            set
            {
                tankIsEnabled = value;
                RaisePropertyChanged(nameof(TankIsEnabled));
            }
        }

        private bool oneTapIsOccupied = false;
        public bool OneTapIsOccupied
        {
            get
            {
                return oneTapIsOccupied;
            }
            set
            {
                oneTapIsOccupied = value;
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
                if (FuelType == Fuel.Petrol)
                {
                    FuelInLiters += 0.2;
                    FuelPrice += 0.3;
                    Thread.Sleep(50);
                }
                if (FuelType == Fuel.Diesel)
                {
                    FuelInLiters += 0.2;
                    FuelPrice += 0.3;
                    Thread.Sleep(50);
                }
                if (FuelType == Fuel.TruckDiesel)
                {
                    FuelInLiters += 0.2;
                    FuelPrice += 0.3;
                    Thread.Sleep(50);
                }
            }
        }

        public void SetToZero()
        {
            FuelInLiters = 0;
            FuelPrice = 0;
        }

        public void ClearGasPump()
        {
            SetToZero();
            AusfahrenIsEnabled = false;
            DieselIsEnabled = false;
            EinfahrenIsEnabled = true;
            PetrolIsEnabled = false;
            TankIsEnabled = false;
            TruckdieselIsEnabled = false;
            IsOccupied = false;
        }


        private void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
