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
        private Game _game;

        public PowerBallViewModel()
        {
            _game = new Game();

            CreateNewGameCommand = new Commands.CreateNewGameCommand(this);
            PlayGameCommand = new Commands.CreateNewGameCommand(this);
        }

        public Game game
        {
            get { return _game; }
            set { _game = value; }
        }

        public void PlayGame()
        {
            game.GenerateGuessValues();
        }

        public ICommand PlayGameCommand
        {
            get;
            private set;
        }

        public void CreateNewGame()
        {
            game.ResetPowerBallValues();
        }

        public ICommand CreateNewGameCommand
        {
            get;
            private set;
        }


        //public int intTotalAmountPaid { get { return obj.TotalAmountPaid; } }
        //public int intCostPerGame { get { return obj.CostPerGame; } }


    }
}
