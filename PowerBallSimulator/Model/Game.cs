using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace PowerBallSimulator.Model
{
    public class Game
    {
        internal WhiteBall actual1;
        internal WhiteBall actual2;
        internal WhiteBall actual3;
        internal WhiteBall actual4;
        internal WhiteBall actual5;
        internal RedBall actual6;
        internal WhiteBall guess1;
        internal WhiteBall guess2;
        internal WhiteBall guess3;
        internal WhiteBall guess4;
        internal WhiteBall guess5;
        internal RedBall guess6;

        internal int TotalAmountPaid { get; set; }
        internal int CostPerGame { get; } = 2;

        public Game()
        {
            GeneratePowerBallValues();
        }

        public void GeneratePowerBallValues()
        {
            // Set Powerball values
            actual1 = new WhiteBall();
            actual2 = new WhiteBall();
            actual3 = new WhiteBall();
            actual4 = new WhiteBall();
            actual5 = new WhiteBall();
            actual6 = new RedBall();
        }

        internal void GenerateGuessValues()
        {
            // Set Guess values
            guess1 = new WhiteBall();
            guess2 = new WhiteBall();
            guess3 = new WhiteBall();
            guess4 = new WhiteBall();
            guess5 = new WhiteBall();
            guess6 = new RedBall();
        }

        internal void ClearGuessValues()
        {
            guess1 = null;
            guess2 = null;
            guess3 = null;
            guess4 = null;
            guess5 = null;
            guess6 = null;
        }

        internal int CalculateWinnings(int[] actuals, int[] guesses)
        {
            int matchCount = 0;

            List<int> Guesses = new List<int>()
            { guess1.Number,
              guess2.Number,
              guess3.Number,
              guess4.Number,
              guess5.Number,
              guess6.Number };

            List<int> Actuals = new List<int>()
            { actual1.Number,
              actual2.Number,
              actual3.Number,
              actual4.Number,
              actual5.Number,
              actual6.Number };

            foreach (int num in Guesses)
            {
                foreach (int num2 in Actuals)
                {
                    if (Guesses[num] == Actuals[num2])
                    {
                        matchCount++;
                        Guesses.Remove(Guesses[num]);
                        Actuals.Remove(Actuals[num2]);
                    }
                }
            }

            return 1;
        }
    }





}
