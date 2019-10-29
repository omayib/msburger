using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msburger.model
{
    class Burger
    {
        public String title { get; set; }
        public String priceString { get; set; }
        private double price;

        public Burger(string title, double price)
        {
            this.title = title;
            this.price = price;
            this.priceString = price.ToString();
        }
    }
}
