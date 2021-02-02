using System;
using System.Collections.Generic;
using System.Linq;

namespace Shopping_Spree
{
    class Person
    {
        public string Name;
        public int Money;
        public List<string> productsList = new List<string>();
    }
    class Product
    {
        public string ProductName;
        public int ProductPrice;
    }
    class Program
    {
        static void Main(string[] args)
        {
            string peopleInput = Console.ReadLine();
            string productInput = Console.ReadLine();

            List<string> inputPeopleList = peopleInput.Split(";").ToList();
            List<string> inputProductList = productInput.Split(";").ToList();

            List<Person> peopleList = new List<Person>();
            List<Product> productList = new List<Product>();
            


            for (int i = 0; i < inputPeopleList.Count; i++)
            {
                
                Person newPerson = new Person();
                newPerson.Name = inputPeopleList[i].Split("=")[0];
                newPerson.Money = int.Parse(inputPeopleList[i].Split("=")[1]);
                peopleList.Add(newPerson);
            }
            for (int i = 0; i < inputProductList.Count; i++)
            {
                if(inputProductList[i].Length==0)
                {
                    break;
                }
                Product newProduct = new Product();
                newProduct.ProductName = inputProductList[i].Split("=")[0];
                newProduct.ProductPrice = int.Parse(inputProductList[i].Split("=")[1]);
                productList.Add(newProduct);
            }
            string command = Console.ReadLine();
            string personToBuy = "";
            string productToBuy = "";
            while (command != "END")
            {
                personToBuy = command.Split()[0];
                productToBuy = command.Split()[1];
                foreach (var person in peopleList)
                {
                    if (person.Name == personToBuy)
                    {
                        foreach (var product in productList)
                        {
                            if (product.ProductName == productToBuy)
                            {
                                if (person.Money >= product.ProductPrice)
                                {
                                    person.Money -= product.ProductPrice;
                                    person.productsList.Add(product.ProductName);
                                    Console.WriteLine($"{person.Name} bought {product.ProductName}");
                                }
                                else
                                {
                                    Console.WriteLine($"{person.Name} can't afford {product.ProductName}");
                                }
                            }
                        }
                    }
                }
                command = Console.ReadLine();
            }
                foreach (var person in peopleList)
                {
                    if (person.productsList.Count == 0)
                    {
                        Console.WriteLine($"{person.Name} - Nothing bought");
                    }
                    else
                        Console.WriteLine($"{person.Name} - {string.Join(", ", person.productsList)}");
                }
                
                   


        }
    }
}
