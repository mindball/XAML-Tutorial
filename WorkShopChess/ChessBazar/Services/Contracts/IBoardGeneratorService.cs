using ChessBazar.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBazar.Services.Contracts
{
    public interface IBoardGeneratorService
    {
        Square[,] Generate();
    }
}
