using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Receipt
    {
        public DateTime DateOfIssue { get; set; }

        public float Price { get; set; }

        public float FuelInLiter { get; set; }

        public float EuroInFrancsPrice { get; set; }        //Api EUR -> FR Kurs

        public float CurrentFuelPriceOfUsedFuelType { get; set; }       //API Kraftstoffkostenpreis

        public List<Product> Products { get; set; } = new List<Product>();

        public float GetFuelPrice()
        {
            float fuelPrice = (FuelInLiter * EuroInFrancsPrice * CurrentFuelPriceOfUsedFuelType);
            Price = fuelPrice;
            return fuelPrice;
        }
    }
}
