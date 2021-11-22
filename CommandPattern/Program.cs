using System;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Patron patron = new Patron();
            //Add
            patron.SetCommand(1);
            patron.SetMenuItem(new MenuItem("Hamburger", 1, 5.40));
            patron.ExecuteCommand();

            patron.ShowCurrentOrder();

            patron.SetCommand(1 /*Add*/);
            patron.SetMenuItem(new MenuItem("Drink", 2, 1.19));
            patron.ExecuteCommand();

            patron.ShowCurrentOrder();

            //Remove the french fries
            patron.SetCommand(3 /*Remove*/);
            patron.SetMenuItem(new MenuItem("French Fries", 2, 1.99));
            patron.ExecuteCommand();

            patron.ShowCurrentOrder();
        }
    }
}
