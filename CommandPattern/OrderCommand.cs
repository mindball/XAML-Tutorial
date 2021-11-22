using System.Collections.Generic;

namespace CommandPattern
{
    public abstract class OrderCommand
    {
        public abstract void Execute(List<MenuItem> order, MenuItem newItem);
    }
}
