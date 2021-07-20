using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EnglishAimlessly2.ViewModel.Commands
{
    public class LoginCommand : ICommand
    {
        readonly UserCredentialVM userVM;

        public LoginCommand(UserCredentialVM vm)
        {
            userVM = vm;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            string[] messages = { "", "Username does not exist, try creating an account!", "Password is incorrect!"};
            int result = userVM.LoginAccount();
            if (result >= messages.Length) return;
            userVM.Hint = messages[result];
        }
    }
}
