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
        private readonly IChessRulesService ruleService;


        private ICommand initCommand;
        private ICommand dragInitCommand;
        private ICommand dragPushCommand;

        private ChessFigure selectedFigure;
        private Square[,] board;

        public ChessGridViewModel(IBoardGeneratorService generator, IChessRulesService ruleService)
        {
            this.generator = generator;
            this.ruleService = ruleService;

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
            this.board = this.generator.Generate();
            foreach (var square in board)
            {
                Squares.Add(square);
            }
        }

        public void DragInit(ChessFigure figure)
        {
            selectedFigure = figure;
            //Task.Run(() =>
            //{
            //    MessageBox.Show(figure.ToString());
            //});
        }

        public void DragPush(ChessFigure figure)
        {
            dynamic dynamicCurrentFigure = this.selectedFigure;
            if (!this.ruleService.Check(this.board, dynamicCurrentFigure, figure))
            {

            }

            var selectedSquare = this.board[this.selectedFigure.Row, this.selectedFigure.Col];
            var destinationSqure = this.board[figure.Row, figure.Col];

            var selectedSquareIndex = Squares.IndexOf(selectedSquare);
            var destinationSquareIndex = Squares.IndexOf(destinationSqure);

            var emptyFigure = new Empty(
                selectedSquare.Row,
                selectedSquare.Col,
                "");

            var cleanSquareFromFigure = 
                new Square(selectedSquare.Row, selectedSquare.Col, selectedSquare.IsWhite, emptyFigure);
            Squares[selectedSquareIndex] = cleanSquareFromFigure;           

            var newSquareWithFigure = 
                new Square(destinationSqure.Row, destinationSqure.Col, destinationSqure.IsWhite, this.selectedFigure);
            Squares[destinationSquareIndex] = newSquareWithFigure;

            this.board[selectedSquare.Row, selectedSquare.Col] = cleanSquareFromFigure;
            this.board[destinationSqure.Row, destinationSqure.Col] = newSquareWithFigure;
            //Task.Run(() =>
            //{
            //    MessageBox.Show(figure.ToString());
            //});
        }
    }
}
