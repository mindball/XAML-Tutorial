using System;

namespace CommandPattern
{
    public class MenuItem
    {
        public string Name { get; set; }

        public int Amount { get; set; }

        public double  Price { get; set; }

        public MenuItem(string name, int amount, double price)
        {
            this.Name = name;
            this.Amount = amount;
            this.Price = price;
        }

        public void Display()
        {
            Console.WriteLine($"\nName: {this.Name}");
            Console.WriteLine($"Amount: {this.Amount}");
            Console.WriteLine($"Price: {this.Price}");
        }
    }
}
