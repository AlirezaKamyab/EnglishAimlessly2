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
using System.Windows.Threading;
using System.Windows;
using EnglishAimlessly2.View;
using EnglishAimlessly2.ViewModel.Base;
using EnglishAimlessly2.ViewModel.Commands.MainMenu;

namespace EnglishAimlessly2.ViewModel
{
    public class MainMenuVM : BaseVM
    {
        private UserModel _loggedUser;
        private GroupModel _selectedGroup;
        private string _nextPracticeCounter;
        private string _groupName = "";
        private string _itemCount;
        private int _masteredWordsCount = 0;
        private int _practiceAvailableCount = 0;

        // Direct Design
        private Visibility _countDownVisiblity = Visibility.Collapsed;
        private Visibility _practiceCountVisibility = Visibility.Visible;
        private Visibility _mainPanelVisibility = Visibility.Collapsed;


        public static MainViewVM MainViewModel { get; set; }
        public string NextPracticeCounter
        {
            get
            {
                return _nextPracticeCounter;
            }
            set
            {
                _nextPracticeCounter = value;
                onPropertyChanged(nameof(NextPracticeCounter));
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
                onPropertyChanged(nameof(ItemCount));
            }
        }

        public int PracticeAvailableCount 
        { 
            get
            {
                return _practiceAvailableCount;
            }
            set
            {
                _practiceAvailableCount = value;
                onPropertyChanged(nameof(PracticeAvailableCount));
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
                onPropertyChanged(nameof(GroupName));
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
                if(DesignerProperties.GetIsInDesignMode(new System.Windows.DependencyObject()) == false) ReloadGroups();
                onPropertyChanged(nameof(LoggedUser));
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
                GroupTableHelper helper = new GroupTableHelper(DatabaseHelper.DATABASE_PATH);
                GroupModel temp = value;
                if (temp != null)
                {
                    helper.Reload();
                    _selectedGroup = helper.SearchById(temp.Id);
                    UpdateInformationForGroup();
                    onPropertyChanged(nameof(SelectedGroup));
                }

                if (SelectedGroup != null) MainPanelVisibility = Visibility.Visible;
                else MainPanelVisibility = Visibility.Collapsed;
            }
        }

        public int MasterWordsCount
        {
            get
            {
                return _masteredWordsCount;
            }
            set
            {
                _masteredWordsCount = value;
                onPropertyChanged(nameof(MasterWordsCount));
            }
        }

        // Direct Design
        public Visibility CountDownVisibility
        {
            get { return _countDownVisiblity; }
            set
            {
                _countDownVisiblity = value;
                onPropertyChanged(nameof(CountDownVisibility));
            }
        }

        public Visibility PracticeCountVisibilty
        {
            get { return _practiceCountVisibility; }
            set
            {
                _practiceCountVisibility = value;
                onPropertyChanged(nameof(PracticeCountVisibilty));
            }
        }

        public Visibility MainPanelVisibility
        {
            get { return _mainPanelVisibility; }
            set
            {
                _mainPanelVisibility = value;
                onPropertyChanged(nameof(MainPanelVisibility));
            }
        }

        public ObservableCollection<GroupModel> Groups { get; set; }
        public CreateGroupCommand CreateGroupCmd { get; set; }
        public RemoveGroupCommand RemoveGroupCmd { get; set; }
        public ChooseOptionCommand ChooseOptionCmd { get; set; }
        public OpenSettingsCommand OpenSettingsCmd { get; set; }
        public OpenHistoryCommand OpenHistoryCmd {  get; set; }

        public MainMenuVM()
        {
            CreateGroupCmd = new CreateGroupCommand(this);
            RemoveGroupCmd = new RemoveGroupCommand(this);
            ChooseOptionCmd = new ChooseOptionCommand(this);
            OpenSettingsCmd = new OpenSettingsCommand(this);
            OpenHistoryCmd = new OpenHistoryCommand(this);
            Groups = new ObservableCollection<GroupModel>();
            LoggedUser = new UserModel();
            if (DesignerProperties.GetIsInDesignMode(new System.Windows.DependencyObject()) == false)
            {
                if(MainViewModel != null && MainViewModel.LoggedUser != null) LoggedUser = MainViewModel.LoggedUser;
            }

        }

        public void AddGroup()
        {
            GroupTableHelper groupHelper = new GroupTableHelper(DatabaseHelper.DATABASE_PATH);
            List<GroupModel> searched = groupHelper.SearchByName(GroupName);
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
            groupHelper.Insert(newGroup);

            ReloadGroups();
            GroupName = "";
        }

        public void RemoveGroup()
        {
            if (SelectedGroup == null) return;

            WordTableHelper wordHelper = new WordTableHelper(DatabaseHelper.DATABASE_PATH);
            GroupTableHelper groupHelper = new GroupTableHelper(DatabaseHelper.DATABASE_PATH);

            List<WordModel> words = wordHelper.SearchByGroupId(SelectedGroup.Id);
            foreach (WordModel item in words)
            {
                wordHelper.Remove(item);
            }
            groupHelper.Remove(SelectedGroup);


            _selectedGroup = null;
            onPropertyChanged(nameof(SelectedGroup));

            ReloadGroups();
            SelectedGroup = null;
        }

        private void UpdateInformationForGroup()
        {
            WordTableHelper wordHelper = new WordTableHelper(DatabaseHelper.DATABASE_PATH);
            ItemCount = wordHelper.SearchByGroupId(SelectedGroup.Id).Count.ToString();
            PracticeAvailableCount = wordHelper.GetSortedDueTime(SelectedGroup).Count;
            MasterWordsCount = wordHelper.GetListByScore(SelectedGroup.Id, 1000).Count;
            UpdateNextPracticeCounter();
        }

        private void UpdateNextPracticeCounter()
        {
            GroupTableHelper groupHelper = new GroupTableHelper(DatabaseHelper.DATABASE_PATH);
            TimeModel nextPractice = groupHelper.NextPractice(SelectedGroup.Id);

            PracticeCountVisibilty = Visibility.Collapsed;
            CountDownVisibility = Visibility.Visible;

            if (nextPractice.Miliseconds <= 0)
            {
                NextPracticeCounter = "Next practice is available";

                PracticeCountVisibilty = Visibility.Visible;
                CountDownVisibility = Visibility.Collapsed;
            }
            else
            {
                int days = (int)nextPractice.Days;
                int hours = (int)nextPractice.Hours - days * 24;
                int minutes = (int)nextPractice.Minutes - hours * 60;

                if (days > 1000000)
                {
                    NextPracticeCounter = string.Format("No practice available");
                }
                else if (days > 0)
                {
                    NextPracticeCounter = string.Format("Next practice is available in {0} day(s) and {1} hours(s)", days, hours);
                }
                else if (hours > 0)
                {
                    NextPracticeCounter = string.Format("Next practice is available in {0} hour(s) and {1} minute(s)", hours, minutes);
                }
                else if (minutes > 0)
                {
                    NextPracticeCounter = string.Format("Next practice is available in {0} minute(s)", minutes);
                }
                else
                {
                    NextPracticeCounter = string.Format("Next practice is available in just a moment");
                }
            }
        }

        private void ReloadGroups()
        {
            if (LoggedUser == null) return;
            GroupTableHelper groupHelper = new GroupTableHelper(DatabaseHelper.DATABASE_PATH);
            Groups.Clear();
            foreach (GroupModel item in groupHelper.SearchByUserId(LoggedUser.Id))
            {
                Groups.Add(item);
            }
        }

        public void OpenSettings()
        {
            GroupSettingsView groupSettingsView= new GroupSettingsView(SelectedGroup);
            groupSettingsView.ShowDialog();
            ReloadGroups();
        }

        public void OpenHistory()
        {
            MainViewModel.SelectedGroup = SelectedGroup;
            MainViewModel.SelectedWord = null;
            HistoryVM.MainViewModel = MainViewModel;
            HistoryView hv = new HistoryView();
            hv.ShowDialog();
        }
    }
}
