using System;
using System.Collections.Generic;
using System.Text;

namespace sales_system
{
    class Product
    {
        private string Name;
        private double Price;
        private string Code;

        public Product (string Name, double Price, string Code)
        {
            this.Name = Name;
            this.Price = Price;
            this.Code = Code;
        }
        public Product()
        {
            this.Name = "";
            this.Price = 0;
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
        public String GetCode()
        {
            return this.Code;
        }
        public void SetCode(string Code)
        {
            this.Code = Code;
        }
    }
}
