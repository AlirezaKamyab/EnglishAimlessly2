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
        private UserCredentialVM UserVM { get; set; }

        public CreateAccountCommand(UserCredentialVM vm)
        {
            UserVM = vm;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            bool permission = (bool)parameter;
            return UserVM.ValidateAccount() && permission;
        }

        public void Execute(object parameter)
        {
            string[] messages = { "", "Username already exists!" };
            int result = UserVM.CreateAccount();
            if (result >= messages.Length) return;
            UserVM.Hint = messages[result];
        }
    }
}
