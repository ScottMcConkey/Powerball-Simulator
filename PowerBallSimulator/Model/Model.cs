using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace PowerBallSimulator.Model
{
    public class Game : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public Game()
        {
            GeneratePowerBalls();
        }

        private void OnPropertyChanged(string p)
        {
            PropertyChangedEventHandler handler = PropertyChanged;

            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(p));
            }
        }

        private PowerBall _actual1;
        private PowerBall _actual2;
        private PowerBall _actual3;
        private PowerBall _actual4;
        private PowerBall _actual5;
        private PowerBall _actual6;
        private PowerBall _guess1;
        private PowerBall _guess2;
        private PowerBall _guess3;
        private PowerBall _guess4;
        private PowerBall _guess5;
        private PowerBall _guess6;

        #region Define PowerBall Properties

        public PowerBall Actual1
        {
            get { return _actual1; }
            set { _actual1 = value; }
        }
        public PowerBall Actual2
        {
            get { return _actual2; }
            set { _actual2 = value; }
        }
        public PowerBall Actual3
        {
            get { return _actual3; }
            set { _actual3 = value; }
        }
        public PowerBall Actual4
        {
            get { return _actual4; }
            set { _actual4 = value; }
        }
        public PowerBall Actual5
        {
            get { return _actual5; }
            set { _actual5 = value; }
        }
        public PowerBall Actual6
        {
            get { return _actual6; }
            set { _actual6 = value; }
        }

        public PowerBall Guess1
        {
            get { return _guess1; }
            set { _guess1 = value; }
        }
        public PowerBall Guess2
        {
            get { return _guess2; }
            set { _guess2 = value; }
        }
        public PowerBall Guess3
        {
            get { return _guess3; }
            set { _guess3 = value; }
        }
        public PowerBall Guess4
        {
            get { return _guess4; }
            set { _guess4 = value; }
        }
        public PowerBall Guess5
        {
            get { return _guess5; }
            set { _guess5 = value; }
        }
        public PowerBall Guess6
        {
            get { return _guess6; }
            set { _guess6 = value; }
        }

        #endregion

        internal int TotalAmountPaid { get; set; }
        internal int CostPerGame { get; } = 2;

        public void GeneratePowerBalls()
        {
            // Set Powerball values
            Actual1 = new WhiteBall();
            Actual2 = new WhiteBall();
            Actual3 = new WhiteBall();
            Actual4 = new WhiteBall();
            Actual5 = new WhiteBall();
            Actual6 = new RedBall();
        }

        internal void ResetPowerBallValues()
        {
            Actual1.AssignNumber();
            Actual2.AssignNumber();
            Actual3.AssignNumber();
            Actual4.AssignNumber();
            Actual5.AssignNumber();
            Actual6.AssignNumber();
        }

        internal void GenerateGuessValues()
        {
            // Set Guess values
            Guess1 = new WhiteBall();
            Guess2 = new WhiteBall();
            Guess3 = new WhiteBall();
            Guess4 = new WhiteBall();
            Guess5 = new WhiteBall();
            Guess6 = new RedBall();
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


        //internal int CalculateWinnings(int[] actuals, int[] guesses)
       //{
       //    int matchCount = 0;
       //
       //    List<int?> Guesses = new List<int?>()
       //    { guess1.Number,
       //      guess2.Number,
       //      guess3.Number,
       //      guess4.Number,
       //      guess5.Number,
       //      guess6.Number };
       //
       //    List<int?> Actuals = new List<int?>()
       //    { _actual1.Number,
       //      actual2.Number,
       //      actual3.Number,
       //      actual4.Number,
       //      actual5.Number,
       //      actual6.Number };
       //
       //    foreach (int num in Guesses)
       //    {
       //        foreach (int num2 in Actuals)
       //        {
       //            if (Guesses[num] == Actuals[num2])
       //            {
       //                matchCount++;
       //                Guesses.Remove(Guesses[num]);
       //                Actuals.Remove(Actuals[num2]);
       //            }
       //        }
       //    }

       //     return 1;
       // }
    }





}
