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
                    ChessFigure figure = new Empty(row, col, "");

                    if((row + col) % 2 == 0)
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
    }
}
