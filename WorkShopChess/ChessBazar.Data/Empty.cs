using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBazar.Data
{
    public class Empty : ChessFigure
    {
        public Empty(int row, int col, string image) 
            : base(row, col, false, image)
        {
            this.Name = "Empty";
        }
    }
}
