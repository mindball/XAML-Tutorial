using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Recognition;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SpeechRecognitionBall
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string LeftDirection = "left";
        private const string RightDirection = "right";
        private const string UpDirection = "up";
        private const string DownDirection = "down";

        private readonly double speed = 0.1;

        private string Direction { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            this.Direction = LeftDirection;

            CompositionTarget.Rendering += Loop;
            StartSpeechRecognition();
        }

        private void StartSpeechRecognition()
        {
            SpeechRecognitionEngine engine = new SpeechRecognitionEngine();
            Choices c = new Choices(new string[] { LeftDirection, RightDirection, UpDirection, DownDirection });
            GrammarBuilder gb = new GrammarBuilder(c);

            Grammar grammar = new Grammar(gb);
            engine.SetInputToDefaultAudioDevice();
            engine.LoadGrammar(grammar);
            engine.SpeechRecognized += RecognizeSpeech;
            engine.RecognizeAsync(RecognizeMode.Multiple);
        }

        private void RecognizeSpeech(object sender, SpeechRecognizedEventArgs e)
        {
            this.Direction = e.Result.Text;
        }

        private void Loop(object sender, EventArgs e)
        {            
            ChangeBallDirection(this.Direction);
        }

        private void ChangeBallDirection(string direction)
        {
            var ballLeft = Canvas.GetLeft(theBall);
            var ballTop = Canvas.GetTop(theBall);

            if (this.Direction == LeftDirection)
            {
                Canvas.SetLeft(theBall, ballLeft - speed);
                //this.Direction = direction;
            }

            if (direction == RightDirection)
            {
                Canvas.SetLeft(theBall, ballLeft + speed);
                //this.Direction = direction;
            }

            if (direction == UpDirection)
            {
                Canvas.SetTop(theBall, ballTop + speed);
                //this.Direction = direction;
            }

            if (direction == DownDirection)
            {
                Canvas.SetTop(theBall, ballTop - speed);
                //this.Direction = direction;
            }
        }
    }
}
