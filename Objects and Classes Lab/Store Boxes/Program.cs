using System;
using System.Collections.Generic;
using System.Linq;

namespace Store_Boxes
{
    public class Item
    {
        public string name;
        public decimal price;
    }

    public class Box
    {
        public string serialNumber;
        
        public Item newItem;
        public int itemQuantity;
        public decimal pricePerBox;
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxesList = new List<Box>();
            string command = Console.ReadLine();

            while (command != "end")
            {
                Item newItem = new Item();
                newItem.name = command.Split()[1];
                newItem.price = decimal.Parse(command.Split()[3]);

                Box newBox = new Box();
                newBox.serialNumber = command.Split()[0];
                newBox.itemQuantity = int.Parse(command.Split()[2]);

                newBox.newItem = newItem;
                newBox.pricePerBox = newBox.itemQuantity * newItem.price;

                

                boxesList.Add(newBox);
      
                 command = Console.ReadLine();
            }
            var result = boxesList.OrderByDescending(x => x.pricePerBox).ToList(); 
            foreach (Box newBox in result)
            {


                Console.WriteLine(($"{newBox.serialNumber}" +
                 $"{Environment.NewLine}-- {newBox.newItem.name} - ${newBox.newItem.price:f2}: {newBox.itemQuantity}" +
                 $"{Environment.NewLine}-- ${newBox.pricePerBox:f2}"));
            }





        }
    }
}
