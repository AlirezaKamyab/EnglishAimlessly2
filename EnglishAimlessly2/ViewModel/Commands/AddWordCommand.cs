using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EnglishAimlessly2.ViewModel.Commands
{
    public class AddWordCommand : ICommand
    {
        private ManagerVM managerViewModel { get; set; }

        public AddWordCommand(ManagerVM mvm)
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
            managerViewModel.AddWord();
        }
    }
}
