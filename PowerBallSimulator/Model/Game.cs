using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace PowerBallSimulator.Model
{
    public class Game : INotifyPropertyChanged
    {
        private readonly int _CostPerGame = 2;
        private int _Payout = 0;
        private int _TotalAmountPaid = 0;
        private int _TotalWinnings = 0;
        
        public int Payout
        {
            get { return _Payout; }
            set
            {
                _Payout = value;
                OnPropertyChanged("Payout");
            }
        }

        public int TotalAmountPaid
        {
            get { return _TotalAmountPaid; }
            set
            {
                _TotalAmountPaid = value;
                OnPropertyChanged("TotalAmountPaid");
            }
        }

        public int TotalWinnings
        {
            get { return _TotalWinnings; }
            set
            {
                _TotalWinnings = value;
                OnPropertyChanged("TotalWinnings");
            }
        }

        internal void ChargeForNewTicket()
        {
            TotalAmountPaid += _CostPerGame;
        }

        public Game()
        {
            GeneratePowerBalls();
            SetActualValues();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string p)
        {
            PropertyChangedEventHandler handler = PropertyChanged;

            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(p));
            }
        }

        #region Define PowerBall Properties

        public PowerBall Actual1 { get; set; }
        public PowerBall Actual2 { get; set; }
        public PowerBall Actual3 { get; set; }
        public PowerBall Actual4 { get; set; }
        public PowerBall Actual5 { get; set; }
        public PowerBall Actual6 { get; set; }

        public PowerBall Guess1 { get; set; }
        public PowerBall Guess2 { get; set; }
        public PowerBall Guess3 { get; set; }
        public PowerBall Guess4 { get; set; }
        public PowerBall Guess5 { get; set; }
        public PowerBall Guess6 { get; set; }

        #endregion

        public void GeneratePowerBalls()
        {
            // Create Powerballs
            Actual1 = new WhiteBall();
            Actual2 = new WhiteBall();
            Actual3 = new WhiteBall();
            Actual4 = new WhiteBall();
            Actual5 = new WhiteBall();
            Actual6 = new RedBall();

            // Create Guesses
            Guess1 = new WhiteBall();
            Guess2 = new WhiteBall();
            Guess3 = new WhiteBall();
            Guess4 = new WhiteBall();
            Guess5 = new WhiteBall();
            Guess6 = new RedBall();
        }

        internal void SetActualValues()
        {
            Actual1.AssignNumber();
            Actual2.AssignNumber();
            Actual3.AssignNumber();
            Actual4.AssignNumber();
            Actual5.AssignNumber();
            Actual6.AssignNumber();
        }

        internal void SetGuessValues()
        {
            Guess1.AssignNumber();
            Guess2.AssignNumber();
            Guess3.AssignNumber();
            Guess4.AssignNumber();
            Guess5.AssignNumber();
            Guess6.AssignNumber();
        }

        internal void ClearGuessValues()
        {
            Guess1.Clear();
            Guess2.Clear();
            Guess3.Clear();
            Guess4.Clear();
            Guess5.Clear();
            Guess6.Clear();
        }

        public void SetPayout()
        {
            int RedActual = (int)Actual6.Number;
            int RedGuess = (int)Guess6.Number;
            int RoundPayout;
            
            List<int> WhiteGuesses = new List<int>()
            { (int)Guess1.Number,
              (int)Guess2.Number,
              (int)Guess3.Number,
              (int)Guess4.Number,
              (int)Guess5.Number
            };
            
            List<int> WhiteActuals = new List<int>()
            { (int)Actual1.Number,
              (int)Actual2.Number,
              (int)Actual3.Number,
              (int)Actual4.Number,
              (int)Actual5.Number
            };

            RoundPayout = PayoutRules.CalculateReturnValue(WhiteGuesses,WhiteActuals,RedActual,RedGuess);
            Payout = RoundPayout;
            TotalWinnings += Payout;
        }

    }

}
