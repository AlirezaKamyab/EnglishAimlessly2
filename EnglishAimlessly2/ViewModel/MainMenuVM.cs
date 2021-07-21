using EnglishAimlessly2.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishAimlessly2.ViewModel
{
    public class MainMenuVM : INotifyPropertyChanged
    {
        private UserModel _loggedUser;
        public UserModel LoggedUser
        {
            get
            {
                return _loggedUser;
            }
            set
            {
                _loggedUser = value;
                OnPropertyChanged(nameof(LoggedUser));
            }
        }

        public ObservableCollection<GroupModel> Groups { get; set; }

        public MainMenuVM()
        {
            LoggedUser = new UserModel();
            Groups = new ObservableCollection<GroupModel>();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
