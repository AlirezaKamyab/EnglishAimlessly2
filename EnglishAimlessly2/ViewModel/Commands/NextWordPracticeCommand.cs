using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EnglishAimlessly2.ViewModel.Commands
{
    public class NextWordPracticeCommand : ICommand
    {
        private PracticeVM pvm;
        public NextWordPracticeCommand(PracticeVM viewModel)
        {
            pvm = viewModel;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            String p = parameter as String;
            if (p == "1") return true;
            else if (p == "2") return true;
            else if (p == "3") return true;
            else return false;
        }

        public void Execute(object parameter)
        {
            String p = parameter as String;
            if (p == "1") pvm.NextWordEasy();
            else if (p == "2") pvm.NextWordNormal();
            else if (p == "3") pvm.NextWordHard();
        }
    }
}
