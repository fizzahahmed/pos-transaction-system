using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp5
{
  
    internal class POS2
    {
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        
        public POS2(string ProductName, double Price, int Quantity)
        {
            this.ProductName = ProductName;
            this.Price = Price;
            this.Quantity = Quantity;
        }

    }
}


