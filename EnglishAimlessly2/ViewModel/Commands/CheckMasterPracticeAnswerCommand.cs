using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EnglishAimlessly2.ViewModel.Commands
{
    public class CheckMasterPracticeAnswerCommand : ICommand
    {
        MasterPracticeVM vm;
        public CheckMasterPracticeAnswerCommand(MasterPracticeVM viewModel)
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
            vm.CheckAnswer();
        }
    }
}
