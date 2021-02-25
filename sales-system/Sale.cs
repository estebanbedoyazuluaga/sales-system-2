using System;
using System.Collections.Generic;
using System.Text;

namespace sales_system
{
    class Sale
    {
        private Product Product;
        private Seller Seller;
        private string Comments;

        public Sale(Product Product, Seller Seller, string Comments)
        {
            this.Product = Product;
            this.Seller = Seller;
            this.Comments = Comments;
        }

        public Product GetProduct()
        {
            return this.Product;
        }
        public void SetProduct(Product Product)
        {
            this.Product = Product;
        }
        public Seller GetSeller()
        {
            return this.Seller;
        }
        public void SetSeller(Seller Seller)
        {
            this.Seller = Seller;
        }
        public string GetCommnets()
        {
            return this.Comments;
        }
        public void SetComments(string Comments)
        {
            this.Comments = Comments;
        }

    }
}
