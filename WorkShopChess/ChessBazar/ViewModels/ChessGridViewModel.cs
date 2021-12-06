using ChessBazar.Data;
using ChessBazar.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ChessBazar.ViewModels
{
    public class ChessGridViewModel     
    {
        private readonly IBoardGeneratorService generator;
        private ICommand initCommand;
        private ICommand dragInitCommand;
        private ICommand dragPushCommand;

        public ChessGridViewModel(IBoardGeneratorService generator)
        {
            this.generator = generator;

            this.Squares = new ObservableCollection<Square>();
        }

        public ObservableCollection<Square> Squares { get; set; }

        public ICommand InitCommand
        {
            get
            {
                if(this.initCommand == null)
                {
                    this.initCommand = new RelayCommand<object>(p => this.Init());
                }
                return this.initCommand;
            }

            set => this.initCommand = value;
        }

        public ICommand DragInitCommand
        {
            get
            {
                if (this.dragInitCommand == null)
                {
                    this.dragInitCommand = new RelayCommand<ChessFigure>(p => this.DragInit(p));
                }
                return this.dragInitCommand;
            }

            set => this.dragInitCommand = value;
        }

        public ICommand DragPushCommand
        {
            get
            {
                if (this.dragPushCommand == null)
                {
                    this.dragPushCommand = new RelayCommand<ChessFigure>(p => this.DragPush(p));
                }
                return this.dragPushCommand;
            }

            set => this.dragPushCommand = value;
        }

        public void Init()
        {
            var board = this.generator.Generate();
            foreach (var square in board)
            {
                Squares.Add(square);
            }
        }

        public void DragInit(ChessFigure figure)
        {
            Task.Run(() =>
            {
                MessageBox.Show(figure.ToString());
            });
        }

        public void DragPush(ChessFigure figure)
        {

            Task.Run(() =>
            {
                MessageBox.Show(figure.ToString());
            });
        }
    }
}
