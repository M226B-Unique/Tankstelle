using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Product
    {
        public string Name { get; set; }

        public float Price { get; set; }

        public string PriceInString
        {
            get
            {
                return (Price.ToString() + " CHF");
            }
        }
    }
}
