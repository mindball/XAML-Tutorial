using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBazar.Data
{
    public class ChessFigure : BasePositionModel
    {
        public ChessFigure(int row, int col, bool isWhite, string image)
        {
            this.Row = row;
            this.Col = col; 
            this.IsWhite = isWhite;
            this.Image = image;
        }

        public string Name { get; set; }

        public bool IsWhite { get; set; }

        public string Image { get; set; }
    }
}
