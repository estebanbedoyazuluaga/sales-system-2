using System;

namespace sales_system
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating sellers
            Seller[] Sellers = new Seller[3];
            Sellers[0] = new Seller("Fulano", 21);
            Sellers[1] = new Seller("Sultano", 18);
            Sellers[2] = new Seller("Mengano", 26);

            //creating products
            Product[] Products = new Product[3];
            Products[0] = new Product("Soy Sauce (750 ml)", 11.99);
            Products[1] = new Product("Instant Ramen (500 grams)", 5.50);
            Products[2] = new Product("Instant Ramen (2000 grams)", 19.99);

            //creating sales
            Sale[] Sales = new Sale[3];
            for (int i = 0; i < Sales.Length; i++)
            {
                Sales[i] = new Sale(Products[i], Sellers[i], "-");
            }

            //calculating total and printing to the console
            double total = 0;
            for (int i = 0; i < Sales.Length; i++)
            {
                total += Sales[i].GetProduct().GetPrice();
                PrintProductPrice(Sales[i]);
            }

            Console.WriteLine("Total: " + Math.Round(total,2));

        }

        public static void PrintProductPrice(Sale Sale)
        {
            Console.WriteLine($"\t{Sale.GetProduct().GetName()} ${Sale.GetProduct().GetPrice()}");
            
            ////More info:
            //Console.WriteLine($"\t{Sale.GetSeller().GetName()} " +
            //                  $"sold {Sale.GetProduct().GetName()} " +
            //                  $"for ${Sale.GetProduct().GetPrice()}" );
        }
    }
}
