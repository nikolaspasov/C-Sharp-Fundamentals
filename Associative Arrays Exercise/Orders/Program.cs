using System;
using System.Collections.Generic;

namespace Orders
{
    class PriceAndQuantity
    {
        public double Price;
        public int Quantity;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, PriceAndQuantity> productDictionary = new Dictionary<string, PriceAndQuantity>();

            string input = Console.ReadLine();
            while (input != "buy")
            {
                PriceAndQuantity newProduct = new PriceAndQuantity();
                newProduct.Price = double.Parse(input.Split()[1]);
                newProduct.Quantity = int.Parse(input.Split()[2]);
                string productName = input.Split()[0];

                if (productDictionary.ContainsKey(productName))
                {
                    productDictionary[productName].Price = newProduct.Price;
                    productDictionary[productName].Quantity += newProduct.Quantity;
                }
                else
                {
                    productDictionary.Add(productName, newProduct);
                }
                input = Console.ReadLine();
            }
            foreach (var product in productDictionary)
            {
                Console.WriteLine($"{product.Key} -> {product.Value.Price*product.Value.Quantity:f2}");
            }
        }
    }
}
