using System.Collections.Generic;

namespace CommandPattern
{
    public class RemoveCommand : OrderCommand
    {
        public override void Execute(List<MenuItem> currentItems, MenuItem newItem)
        {
            currentItems.Add(newItem);
        }
    }
}
