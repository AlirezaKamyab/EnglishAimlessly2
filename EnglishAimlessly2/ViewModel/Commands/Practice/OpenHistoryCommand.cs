using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EnglishAimlessly2.ViewModel.Commands.Practice
{
    public class OpenHistoryCommand : ICommand
    {
        private PracticeVM vm;
        public OpenHistoryCommand(PracticeVM viewModel)
        {
            vm = viewModel;
        }
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            vm.OpenHistory();
        }
    }
}
