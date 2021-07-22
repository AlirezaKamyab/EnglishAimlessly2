using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EnglishAimlessly2.ViewModel.Commands
{
    public class RemoveWordCommand : ICommand
    { 
        private ManagerVM managerViewModel { get; set; }
        public RemoveWordCommand(ManagerVM mvm)
        {
            managerViewModel = mvm;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            managerViewModel.RemoveWord();
        }
    }
}
