using ChessBazar.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBazar.Services.Contracts
{
    public interface IChessRulesService
    {
        bool Check(Square[,] board, ChessFigure from, ChessFigure to);

        bool Check(Square[,] board, Pawn from, ChessFigure to);

        bool Check(Square[,] board, Knight from, ChessFigure to);
    }
}
