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

        private readonly UserTableHelper _userTableHelper;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
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
                OnPropertyChanged(nameof(Lastname));
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
                OnPropertyChanged(nameof(Email));
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
                OnPropertyChanged(nameof(Username));
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
                OnPropertyChanged(nameof(Password));
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
                OnPropertyChanged(nameof(Birthday));
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
                OnPropertyChanged(nameof(Hint));
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
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void CreateAccount()
        {
            UserModel userModel = new(Name, Lastname, Email, Birthday, Username, Password);
            userModel.CreatedAccountDate = DateTime.Now;

            if (_userTableHelper.SearchByUsername(Username).Id != -1)
            {
                Hint = "Username is already taken!";
                return;
            }

            _userTableHelper.Insert(userModel);
            Registered?.Invoke(this, userModel);
        }

        public void LoginAccount()
        {
            UserModel foundUsername = _userTableHelper.SearchByUsername(Username);
            if (foundUsername.Id == -1)
            {
                Hint = "Username does not exist";
                return; 
            }
            if (_userTableHelper.isValidCredential(foundUsername.Username, Password) == false)
            {
                Hint = "Password is incorrect";
                return;
            }
            //Login to account
            Loggedin?.Invoke(this, foundUsername);
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

        public delegate void LoginHandler(object sender, UserModel user);
        public delegate void RegisterHandler(object sender, UserModel user);
        public event LoginHandler Loggedin;
        public event RegisterHandler Registered;
    }
}
