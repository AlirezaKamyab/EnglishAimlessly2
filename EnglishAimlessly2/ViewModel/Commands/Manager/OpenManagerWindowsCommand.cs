using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EnglishAimlessly2.ViewModel.Commands.Manager
{
    public class OpenManagerWindowsCommand : ICommand
    {
        ManagerVM vm;
        public OpenManagerWindowsCommand(ManagerVM viewModel)
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
            if(parameter.ToString() == "Edit")
            {
                vm.OpenEdit();
            }
            else if(parameter.ToString() == "Add")
            {
                vm.OpenAdd();
            }
            else if(parameter.ToString() == "AddTogether")
            {
                vm.OpenAddTogether();
            }
            else if(parameter.ToString() == "GroupSettings")
            {
                vm.OpenGroupSettings();
            }
            else if (parameter.ToString() == "History")
            {
                vm.OpenHistory();
            }
        }
    }
}
