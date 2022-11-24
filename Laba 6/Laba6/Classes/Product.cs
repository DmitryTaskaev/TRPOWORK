using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba6.Classes
{
    class Product
    {
        public string ProductName { get; set; }
        public string ImageFile { get; set; }
        public int Count { get; set; }
        public decimal Price { get; set; }
        public double Discount { get; set; }

        public bool HashDiscount
        {
            get
            {
                return Discount > 0;
            }
        }

        public decimal DiscountPrise
        {
            get
            {
                return Price * (decimal)(1 - Discount);
            }
        }
    }
}
