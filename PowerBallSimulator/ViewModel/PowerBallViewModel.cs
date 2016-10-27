using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using PowerBallSimulator.Model;

namespace PowerBallSimulator.ViewModel
{
    public class PowerBallViewModel
    {
        public string txtActual1 { get; set; }
        public string txtActual2 { get; set; }
        public string txtActual3 { get; set; }
        public string txtActual4 { get; set; }
        public string txtActual5 { get; set; }
        public string txtActual6 { get; set; }
        public string txtGuess1 { get; set; }
        public string txtGuess2 { get; set; }
        public string txtGuess3 { get; set; }
        public string txtGuess4 { get; set; }
        public string txtGuess5 { get; set; }
        public string txtGuess6 { get; set; }

        public PowerBallViewModel()
        {
            Game obj = new Game();
            obj.GenerateGuessValues();
            txtActual1 = obj.actual1.Number.ToString();
            txtActual2 = obj.actual2.Number.ToString();
            txtActual3 = obj.actual3.Number.ToString();
            txtActual4 = obj.actual4.Number.ToString();
            txtActual5 = obj.actual5.Number.ToString();
            txtActual6 = obj.actual6.Number.ToString();
            txtGuess1 = obj.guess1.Number.ToString();
            txtGuess2 = obj.guess2.Number.ToString();
            txtGuess3 = obj.guess3.Number.ToString();
            txtGuess4 = obj.guess4.Number.ToString();
            txtGuess5 = obj.guess5.Number.ToString();
            txtGuess6 = obj.guess6.Number.ToString();
        }

            //public int intTotalAmountPaid { get { return obj.TotalAmountPaid; } }
            //public int intCostPerGame { get { return obj.CostPerGame; } }
            

    }
}

        //public void ResetPowerballs()
        //{
        //    obj.GeneratePowerBallValues();
        //}
    //public ICommand PlayGame_Click()
    //{

    //    obj.GeneratePowerBallValues();
    //}
