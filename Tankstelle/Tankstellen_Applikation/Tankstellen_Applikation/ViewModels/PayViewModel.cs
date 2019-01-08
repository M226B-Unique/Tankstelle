using BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tankstellen_Applikation.ViewModels
{
    public class PayViewModel : INotifyPropertyChanged
    {
        private Receipt customerReceipt;
        private List<string> productDisplayList = new List<string>();
        private float productDisplayPrice;
        public float Price { get; set; }

        public Fuel FuelTypeUsed { get; set; }

        public PayViewModel()
        {
            if(CustomerReceipt == null)
            {
                CustomerReceipt = new Receipt();
            }
        }

        public Receipt CustomerReceipt
        {
            get
            {
                return customerReceipt;
            }
            set
            {
                customerReceipt = value;
                RaisePropertyChanged(nameof(CustomerReceipt));
                RaisePropertyChanged(nameof(ProductDisplayList));
            }
        }

        public List<string> ProductDisplayList
        {
            get
            {
                return productDisplayList;
            }
            set
            {
                productDisplayList = value;
                RaisePropertyChanged(nameof(ProductDisplayList));
            }
        }

        public float ProductDisplayPrice
        {
            get
            {
                return productDisplayPrice;
            }
            set
            {
                productDisplayPrice = value;
                RaisePropertyChanged(nameof(ProductDisplayPrice));
            }
        }
        /// <summary>
        /// This method gets all Products and the full information of how much the final price is...
        /// </summary>
        public void GetAllInformationsIntoTheViewProperties()
        {
            ProductDisplayList.Add("Fuelprice: " + CustomerReceipt.Price.ToString() + " CHF");
            ProductDisplayPrice += CustomerReceipt.Price;
            foreach(Product product in CustomerReceipt.Products)
            {
                ProductDisplayList.Add(product.Name + " | " + product.Price.ToString() + "CHF");
                ProductDisplayPrice += product.Price;
            }
        }

        public void ClearAllInformations()
        {
            ProductDisplayList = null;
            ProductDisplayPrice = 0;

            ProductDisplayList = new List<string>();
        }

        private void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
