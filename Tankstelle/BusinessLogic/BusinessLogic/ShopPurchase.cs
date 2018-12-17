using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class ShopPurchase
    {
        public List<Product> Products { get; set; }

        public double? ShopPruchasePrice
        {
            get
            {
                double? totalPrice = null;
                foreach (Product product in Products)
                {
                    totalPrice += product.Price;
                }
                return totalPrice;
            }
        }


    }
}
