using System;

namespace sales_system
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating sellers
            Seller MySeller_1 = new Seller("Fulano", 21);
            Seller MySeller_2 = new Seller("Sultano", 18);
            Seller MySeller_3 = new Seller("Mengano", 26);

            //creating products
            Product MyProduct_1 = new Product("Soy Sauce (750 ml)", 11.99);
            Product MyProduct_2 = new Product("Instant Ramen (500 grams)", 5.50);
            Product MyProduct_3 = new Product("Instant Ramen (2000 grams)", 19.99);

            //creating sales
            Sale MySale_1 = new Sale(MyProduct_1, MySeller_1, "-");
            Sale MySale_2 = new Sale(MyProduct_2, MySeller_2, "-");
            Sale MySale_3 = new Sale(MyProduct_3, MySeller_3, "-");

            //calculating total and printing to the console
            double total = 0;

            total += MySale_1.GetProduct().GetPrice();
            PrintProductPrice(MySale_1);

            total += MySale_2.GetProduct().GetPrice();
            PrintProductPrice(MySale_2);

            total += MySale_3.GetProduct().GetPrice();
            PrintProductPrice(MySale_3);

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
