using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EnglishAimlessly2.ViewModel.Commands
{
    public class CreateAccountCommand : ICommand
    {
        private UserCredentialVM userVM { get; set; }

        public CreateAccountCommand(UserCredentialVM vm)
        {
            userVM = vm;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return userVM.ValidateAccount();
        }

        public void Execute(object parameter)
        {
            string[] messages = { "", "Username already exists!" };
            int result = userVM.CreateAccount();
            if (result >= messages.Length) return;
            userVM.Hint = messages[result];
        }
    }
}
