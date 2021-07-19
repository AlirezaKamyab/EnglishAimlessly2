using EnglishAimlessly2.Model;
using EnglishAimlessly2.ViewModel.Commands;
using EnglishAimlessly2.ViewModel.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishAimlessly2.ViewModel
{
    public class UserCredentialVM : INotifyPropertyChanged
    {
        private const int MIN_USERNAME_CHAR = 3;
        private const int MIN_PASSWORD_CHAR = 8;

        private string _name;
        private string _lastname;
        private string _email;
        private string _username;
        private string _password;
        private DateTime _birthDay = DateTime.Now;
        private string _hint;

        private UserTableHelper _userTableHelper;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                onPropertyChanged("Name");
            }
        }

        public string Lastname
        {
            get
            {
                return _lastname;
            }
            set
            {
                _lastname = value;
                onPropertyChanged("Lastname");
            }
        }

        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
                onPropertyChanged("Email");
            }
        }

        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
                ValidateAccount(true);
                onPropertyChanged("Username");
            }
        }

        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
                ValidateAccount(true);
                onPropertyChanged("Password");
            }
        }

        public DateTime Birthday
        {
            get
            {
                return _birthDay;
            }
            set
            {
                _birthDay = value;
                onPropertyChanged("Birthday");
            }
        }

        public string Hint
        {
            get
            {
                return _hint;
            }
            set
            {
                _hint = value;
                onPropertyChanged("Hint");
            }
        }

        public CreateAccountCommand CreateAccountCmd { get; set; }
        public LoginCommand LoginCmd { get; set; }

        public UserCredentialVM()
        {
            CreateAccountCmd = new CreateAccountCommand(this);
            LoginCmd = new LoginCommand(this);
            if (DesignerProperties.GetIsInDesignMode(new System.Windows.DependencyObject()) == false)
            {
                _userTableHelper = new UserTableHelper(DatabaseHelper.DATABASE_PATH);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void onPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public int CreateAccount()
        {
            UserModel userModel = new UserModel(Name, Lastname, Email, Birthday, Username, Password);
            userModel.CreatedAccountDate = DateTime.Now;

            if (_userTableHelper.SearchByUsername(Username).Id != -1) return 1;
            if (Username.Length < 3 || Password.Length < 8) return 2;
            _userTableHelper.Insert(userModel);
            return 0;
        }

        public int LoginAccount()
        {
            UserModel foundUsername = _userTableHelper.SearchByUsername(Username);
            if (foundUsername.Id == -1) return 1;
            if (_userTableHelper.isValidCredential(foundUsername.Username, Password) == false) return 2;
            //Login to account
            return 0;
        }

        public bool ValidateAccount(bool updateHint = false)
        {
            if (string.IsNullOrWhiteSpace(Username) || Username.Length < MIN_USERNAME_CHAR)
            {
                if(updateHint) Hint = $"Username must be at least {MIN_USERNAME_CHAR} characters";
                return false;
            }
            if (string.IsNullOrEmpty(Password) || Password.Length < MIN_PASSWORD_CHAR)
            {
                if (updateHint) Hint = $"Password must be at least {MIN_PASSWORD_CHAR} characters";
                return false;
            }
            if (updateHint) Hint = "";
            return true;
        }
    }
}
