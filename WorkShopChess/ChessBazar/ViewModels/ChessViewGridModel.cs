using ChessBazar.Data;
using ChessBazar.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ChessBazar.ViewModels
{
    public class ChessViewGridModel : ICommand
    {
        private readonly IBoardGeneratorService _generator;
        public ChessViewGridModel(IBoardGeneratorService generator)
        {
            this._generator = generator;
        }

        public ObservableCollection<Square> ChessGrid { get; set; }


    }
}
