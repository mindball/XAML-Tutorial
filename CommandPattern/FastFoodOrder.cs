using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class FastFoodOrder
    {
        public List<MenuItem> CurrentItems { get; set; } = new List<MenuItem>();

        public void ExecuteCommand(OrderCommand command, MenuItem item)
        {
            command.Execute(this.CurrentItems, item);
        }

        public void ShowCurrentItems()
        {
            foreach (var item in this.CurrentItems)
            {
                item.Display();
            }

            Console.WriteLine(new string('-', 20));
        }
    }
}
