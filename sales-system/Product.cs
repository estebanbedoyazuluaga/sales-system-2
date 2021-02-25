using System;
using System.Collections.Generic;
using System.Text;

namespace sales_system
{
    class Product
    {
        private string Name;
        private double Price;

        public Product (string Name, double Price)
        {
            this.Name = Name;
            this.Price = Price;
        }

        public string GetName()
        {
            return this.Name;
        }
        public void SetName(string Name)
        {
            this.Name = Name;
        }
        public double GetPrice()
        {
            return this.Price;
        }
        public void SetPrice(double Price)
        {
            this.Price = Price;
        }
    }
}
