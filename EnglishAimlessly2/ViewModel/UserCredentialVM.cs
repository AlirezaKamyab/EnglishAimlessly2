using EnglishAimlessly2.Model;
using EnglishAimlessly2.ViewModel.Base;
using EnglishAimlessly2.ViewModel.Commands;
using EnglishAimlessly2.ViewModel.Helper;
using System.Collections.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace EnglishAimlessly2.ViewModel
{
    public class UserCredentialVM : BaseVM, INotifyPropertyChanged
    {
        private const int MIN_USERNAME_CHAR = 3;

        private string _name;
        private string _email;
        private string _username;
        private string _hint;
        private UserModel _selectedUser;

        public static MainViewVM MainViewModel { get; set; }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                onPropertyChanged(nameof(Name));
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
                onPropertyChanged(nameof(Email));
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
                onPropertyChanged(nameof(Username));
            }
        }

        public UserModel SelectedUser
        {
            get { return _selectedUser; }
            set
            {
                _selectedUser = value;
                onPropertyChanged(nameof(SelectedUser));
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
                onPropertyChanged(nameof(Hint));
            }
        }

        public ObservableCollection<UserModel> Users { get; set; }
        public CreateAccountCommand CreateAccountCmd { get; set; }
        public LoginCommand LoginCmd { get; set; }

        public UserCredentialVM()
        {
            Users = new ObservableCollection<UserModel>();
            CreateAccountCmd = new CreateAccountCommand(this);
            LoginCmd = new LoginCommand(this);
            if (DesignerProperties.GetIsInDesignMode(new System.Windows.DependencyObject()) == false)
            {
                Reload();
            }
        }

        public void Reload()
        {
            UserTableHelper UserTableHelper = new UserTableHelper(DatabaseHelper.DATABASE_PATH);
            Users.Clear();
            foreach (UserModel item in UserTableHelper.GetData())
            {
                Users.Add(item);
            }
        }

        public bool CreateAccount()
        {
            UserTableHelper UserTableHelper = new UserTableHelper(DatabaseHelper.DATABASE_PATH);
            UserModel userModel = new UserModel(Name, Email, Username);
            userModel.CreatedAccountDate = DateTime.Now;

            if (UserTableHelper.SearchByUsername(Username).Id != -1)
            {
                MessageBox.Show("Username exists, try another one", "Error", MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.OK);
                return false;
            }
            UserTableHelper.Insert(userModel);
            return true;
        }

        public bool LoginAccount()
        {
            if (SelectedUser == null) return false; ;
            UserTableHelper UserTableHelper = new UserTableHelper(DatabaseHelper.DATABASE_PATH);
            UserModel foundUsername = UserTableHelper.SearchByUsername(SelectedUser.Username);
            if (foundUsername.Id == -1)
            {
                return false; 
            }
            //Login to account
            MainViewModel.LoggedUser = foundUsername;
            return true;
        }

        public bool ValidateAccount(bool updateHint = false)
        {
            if (string.IsNullOrWhiteSpace(Username) || Username.Length < MIN_USERNAME_CHAR)
            {
                if(updateHint) Hint = $"Username must be at least {MIN_USERNAME_CHAR} characters";
                return false;
            }
            if (updateHint) Hint = "";
            return true;
        }
    }
}
