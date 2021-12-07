using ChessBazar.Data;
using ChessBazar.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBazar.Services
{
    public class ChessRulesService : IChessRulesService
    {
        public bool Check(Square[,] board, ChessFigure from, ChessFigure to)
        {
            throw new NotImplementedException();
        }

        public bool Check(Square[,] board, Pawn from, ChessFigure to)
        {
            throw new NotImplementedException();
        }

        public bool Check(Square[,] board, Knight from, ChessFigure to)
        {
            throw new NotImplementedException();
        }
    }
}
