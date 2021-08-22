using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EnglishAimlessly2.ViewModel.Commands
{
    public class CreateGroupCommand : ICommand
    {
        public MainMenuVM MainMenuViewModel { get; set; }

        public CreateGroupCommand(MainMenuVM mmvm)
        {
            MainMenuViewModel = mmvm;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            if (MainMenuViewModel.GroupName.Trim().Length < 3) return false;
            return true;
        }

        public void Execute(object parameter)
        {
            MainMenuViewModel.AddGroup();
        }
    }
}
