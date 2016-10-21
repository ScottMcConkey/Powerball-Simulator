using System;
using System.Collections.Generic;
using System.Linq;
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

namespace PowerBallSimulator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly int CostToPlay = 2;
        private int TotalAmountPaid;
        public int[] Actuals = new int[6];
        public int[] Guesses = new int[6];

        public MainWindow()
        {
            InitializeComponent();
            GeneratePowerBallValues();
            Game game = new Game();
        }

        private void newgame_Click(object sender, RoutedEventArgs e)
        {
            GeneratePowerBallValues();
            ClearGuessValues();
        }

        private void play_Click(object sender, RoutedEventArgs e)
        {
            // Pay for each guess
            TotalAmountPaid += CostToPlay;
            this.TotalCost.Text = String.Format("{0:C}",TotalAmountPaid);

            GenerateGuessValues();
        }

        private void GeneratePowerBallValues()
        {
            // Set Powerball values
            PowerBall white1 = new White();
            this.Actual1.Text = white1.Number.ToString();

            PowerBall white2 = new White();
            this.Actual2.Text = white2.Number.ToString();

            PowerBall white3 = new White();
            this.Actual3.Text = white3.Number.ToString();

            PowerBall white4 = new White();
            this.Actual4.Text = white4.Number.ToString();

            PowerBall white5 = new White();
            this.Actual5.Text = white5.Number.ToString();

            // Set Red Powerball
            PowerBall red = new Red();
            this.Actual6.Text = red.Number.ToString();
        }

        private void GenerateGuessValues()
        {
            // Set Guess values
            PowerBall white1 = new White();
            this.Guess1.Text = white1.Number.ToString();

            PowerBall white2 = new White();
            this.Guess2.Text = white2.Number.ToString();

            PowerBall white3 = new White();
            this.Guess3.Text = white3.Number.ToString();

            PowerBall white4 = new White();
            this.Guess4.Text = white4.Number.ToString();

            PowerBall white5 = new White();
            this.Guess5.Text = white5.Number.ToString();

            // Set Red Powerball
            PowerBall red = new Red();
            this.Guess6.Text = red.Number.ToString();
        }

        private void ClearGuessValues()
        {
            this.Guess1.Text = null;
            this.Guess2.Text = null;
            this.Guess3.Text = null;
            this.Guess4.Text = null;
            this.Guess5.Text = null;
            this.Guess6.Text = null;
        }

        private void Payout_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
