using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PowerBallSimulator.Commands
{
    internal class CreateNewGameCommand : ICommand
    {
        private ViewModel.PowerBallViewModel _viewModel;
        public CreateNewGameCommand(ViewModel.PowerBallViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        #region Implement ICommand

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _viewModel.CreateNewGame();
        }

        #endregion
    }

    internal class PlayGameCommand : ICommand
    {
        private ViewModel.PowerBallViewModel _viewModel;
        public PlayGameCommand(ViewModel.PowerBallViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        #region Implement ICommand

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _viewModel.PlayGame();
        }

        #endregion
    }
}
