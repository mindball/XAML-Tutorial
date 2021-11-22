using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{

    public class Patron
    {
        private OrderCommand orderCommand;
        private MenuItem menuItem;
        private FastFoodOrder order;

        public Patron()
        {
            order = new FastFoodOrder();
        }

        public void SetCommand(int commandOption)
        {
            orderCommand = new CommandFactory().GetCommand(commandOption);
        }

        public void SetMenuItem(MenuItem menuItem)
        {
            this.menuItem = menuItem;

        }

        public void ExecuteCommand()
        {
            order.ExecuteCommand(this.orderCommand, this.menuItem);
        }

        public void ShowCurrentOrder()
        {
            order.ShowCurrentItems();
        }
        
    }
}
