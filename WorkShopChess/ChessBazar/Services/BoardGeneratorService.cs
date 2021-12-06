using ChessBazar.Common;
using ChessBazar.Data;
using ChessBazar.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static ChessBazar.Common.Constants;

namespace ChessBazar.Services
{
    public class BoardGeneratorService : IBoardGeneratorService
    {     

        public Square[,] Generate()
        {
            Square[,] board = new Square[BoardRows, BoardCols];
            for (int row = 0; row < BoardRows; row++)
            {
                for (int col = 0; col < BoardCols; col++)
                {
                    Square square = null;
                    var figure = this.GetFigure(row, col);  
                    
                    if ((row + col) % 2 == 0)
                    {
                        square = new Square(row, col, true, figure);
                    }
                    else
                    {
                        square = new Square(row, col, false, figure);
                    }

                    board[row, col] = square;
                }
            }

            return board;
        }

        private ChessFigure GetFigure(int row, int col)
        {
            ChessFigure figure = new Empty(row, col, "");

            if(row == 0)
            {
                if(col == 1 || col == 6)
                {
                    figure = new Knight(row, col, false, "/Images/blackknight.png");
                }
            }

            if (row == 7)
            {
                if (col == 1 || col == 6)
                {
                    figure = new Knight(row, col, true, "/Images/whiteknight.png");
                }
            }

            if (row == 1)
            {
                figure = new Pawn(row, col, false, "/Images/blackpawn.png");
            }
            if (row == 6)
            {
                figure = new Pawn(row, col, true, "/Images/whitepawn.png");
            }

            return figure;
        }
    }
}
