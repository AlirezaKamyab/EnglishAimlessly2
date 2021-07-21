using EnglishAimlessly2.Model;
using EnglishAimlessly2.ViewModel.Commands;
using EnglishAimlessly2.ViewModel.Helper;
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
        private GroupTableHelper _groupHelper;
        private WordTableHelper _wordHelper;
        private GroupModel _selectedGroup;
        private string _groupName;
        private string _itemCount;
        private string _newWords;

        public string NewWords
        {
            get
            {
                return _newWords;
            }
            set
            {
                _newWords = value;
                OnPropertyChanged(nameof(NewWords));
            }
        }
        public string ItemCount
        {
            get
            {
                return _itemCount;
            }
            set
            {
                _itemCount = value;
                OnPropertyChanged(nameof(ItemCount));
            }
        }

        public string GroupName
        {
            get
            {
                return _groupName;
            }
            set
            {
                _groupName = value;
                OnPropertyChanged(nameof(GroupName));
            }
        }

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

        public GroupModel SelectedGroup
        {
            get
            {
                return _selectedGroup;
            }
            set
            {
                _selectedGroup = value;
                UpdateInformationForGroup();
                OnPropertyChanged(nameof(SelectedGroup));
            }
        }

        public ObservableCollection<GroupModel> Groups { get; set; }
        public CreateGroupCommand CreateGroupCmd { get; set; }

        public MainMenuVM()
        {
            LoggedUser = new UserModel();
            CreateGroupCmd = new CreateGroupCommand(this);
            Groups = new ObservableCollection<GroupModel>();
            if (DesignerProperties.GetIsInDesignMode(new System.Windows.DependencyObject()) == false)
            {
                _groupHelper = new GroupTableHelper(DatabaseHelper.DATABASE_PATH);
                _wordHelper = new WordTableHelper(DatabaseHelper.DATABASE_PATH);
                ReloadGroups();
            }
        }

        public void AddGroup()
        {
            List<GroupModel> searched = _groupHelper.SearchByName(GroupName);
            foreach (GroupModel item in searched)
            {
                if (item.Id == LoggedUser.Id) return;
            }
            GroupModel newGroup = new GroupModel();
            newGroup.Name = GroupName;
            newGroup.UserId = LoggedUser.Id;
            newGroup.CreationDate = DateTime.Now;
            newGroup.UpdatedDate = DateTime.Now;
            newGroup.Description = "Description Here"; // This should be updated later
            _groupHelper.Insert(newGroup);
            ReloadGroups();
            GroupName = "";
        }

        void UpdateInformationForGroup()
        {
            _wordHelper.Reload();
            ItemCount = _wordHelper.SearchByGroupId(SelectedGroup.Id).Count.ToString();
            NewWords = _wordHelper.SearchWordsByPractice(SelectedGroup.Id, 0, false).Count.ToString();
        }

        void ReloadGroups()
        {
            _groupHelper.Reload();
            Groups.Clear();
            foreach (GroupModel item in _groupHelper.GetData())
            {
                Groups.Add(item);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
