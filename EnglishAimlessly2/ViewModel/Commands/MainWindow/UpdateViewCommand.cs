using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EnglishAimlessly2.ViewModel.Commands.MainWindow
{
    public class UpdateViewCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private MainViewVM mvvm;
        public UpdateViewCommand(MainViewVM viewModel)
        {
            mvvm = viewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            mvvm.ChangeViewByName(parameter.ToString());
        }
    }
}
