using System;

namespace sales_system
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating sellers
            Seller[] Sellers = new Seller[3];
            Sellers[0] = new Seller("Alice", 21);
            Sellers[1] = new Seller("Bob", 18);
            Sellers[2] = new Seller("Carl", 26);

            //creating products
            Product[] Products = new Product[3];
            Products[0] = new Product("Soy Sauce (750 ml)", 11.99, "0001");
            Products[1] = new Product("Instant Ramen (500 grams)", 5.50, "0002");
            Products[2] = new Product("Instant Ramen (2000 grams)", 19.99, "0003");
            //this array contains the number of times each product has been sold
            int[] product_times_sold = new int[Products.Length];
            for (int i = 0; i < product_times_sold.Length; i++)
            {
                product_times_sold[i] = 0;
            }

            //creating sales
            Sale[] Sales = new Sale[6];
            for (int i = 0; i < 3; i++)
            {
                Sales[i] = new Sale(Products[i], Sellers[i], "-");
            }
            //Creating some more sales
            Sales[3] = new Sale(Products[1], Sellers[0], "-");
            Sales[4] = new Sale(Products[1], Sellers[1], "-");
            Sales[5] = new Sale(Products[1], Sellers[2], "-");

            //processing today's sales
            double total = 0;
            Product current_product = new Product();
            string cheapest_product_seller = "";
            double cheapest_product_price = 0.0;
            Product most_expensive_product = new Product();


            for (int i = 0; i < Sales.Length; i++)
            {
                current_product = Sales[i].GetProduct();

                //increase the number of times this product has been sold.
                product_times_sold[GetProductPosition(current_product.GetCode(), Sales)]++;

                //this keeps track of who sold the cheapest product.
                if (i == 0 || Sales[i].GetProduct().GetPrice() < cheapest_product_price)
                {
                    cheapest_product_price = current_product.GetPrice();
                    cheapest_product_seller = Sales[i].GetSeller().GetName();
                }

                //this keeps track of the most expensive product.
                if (i == 0 || Sales[i].GetProduct().GetPrice() > most_expensive_product.GetPrice())
                {
                    most_expensive_product = current_product;
                }

                //add up to total 
                total += Sales[i].GetProduct().GetPrice();
                //print product
                //-----------------{tab}----------------[product name]---------------------[product price]
                Console.WriteLine($"\t{Sales[i].GetProduct().GetName()} ${Sales[i].GetProduct().GetPrice()}");
            }

            double average_product_price = total / Sales.Length;

            //Printing system reports

            //Total
            Console.WriteLine("Total: $" + Math.Round(total, 2));
            //who sold the cheapest item
            Console.WriteLine($"{cheapest_product_seller} sold the cheapest item.");
            //average product price
            Console.WriteLine($"${Math.Round(average_product_price, 2)} " +
                               "is today's average product price.");
            //most expensive item
            Console.WriteLine($"{most_expensive_product.GetName()} " +
                              $"[${Math.Round(most_expensive_product.GetPrice(), 2)}] " +
                               "was the most expensive product.");
            //products and how many times each was sold
            for (int i = 0; i < Products.Length; i++)
            {
                Console.WriteLine($"\t{Products[i].GetName()} was sold {product_times_sold[i]} times.");
            }

        }
        private static int GetProductPosition(string Code, Sale[] Sales)
        {
            //This returns the position of an item inside an array of sales (given that 
            //all codes are unique and that there's an item that corresponds to that 
            //code inside the provided array).
            for (int i = 0; i < Sales.Length; i++)
            {
                if (Sales[i].GetProduct().GetCode() == Code)
                {
                    return i;
                }
            }
            return 0;
        }
    }
}
