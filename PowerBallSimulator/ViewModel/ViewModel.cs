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
        public PowerBallViewModel()
        {
            game = new Game();

            CreateNewGameCommand = new Commands.CreateNewGameCommand(this);
            PlayGameCommand = new Commands.PlayGameCommand(this);
        }

        public Game game { get; set; }

        public void CreateNewGame()
        {
            game.ClearGuessValues();
            game.SetActualValues();
        }

        public void PlayGame()
        {
            game.SetGuessValues();
            game.ChargeForNewTicket();
            game.SetPayout();
        }

        public ICommand PlayGameCommand
        {
            get;
            private set;
        }

        public ICommand CreateNewGameCommand
        {
            get;
            private set;
        }


    }
}
