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

            //processing today's sales
            double total = 0;
            string cheapest_product_seller = "";
            double cheapest_product_price = 0.0;
            
            for (int i = 0; i < Sales.Length; i++)
            {
                //this keeps track of who sold the cheapest product.
                if (i == 0)
                {
                    cheapest_product_price = Sales[i].GetProduct().GetPrice();
                    cheapest_product_seller = Sales[i].GetSeller().GetName();
                }
                else if (Sales[i].GetProduct().GetPrice() < cheapest_product_price)
                {
                    cheapest_product_price = Sales[i].GetProduct().GetPrice();
                    cheapest_product_seller = Sales[i].GetSeller().GetName();
                }

                //add up to total and print product
                total += Sales[i].GetProduct().GetPrice();

                //-----------------{tab}----------------[product name]---------------------[product price]
                Console.WriteLine($"\t{Sales[i].GetProduct().GetName()} ${Sales[i].GetProduct().GetPrice()}");
            }

            double average_product_price = total / Sales.Length;
            Console.WriteLine("Total: " + Math.Round(total, 2));
            Console.WriteLine($"{cheapest_product_seller} sold the cheapest item.");
            Console.WriteLine($"${Math.Round(average_product_price, 2)} is today's average product price.");

        }
    }
}
