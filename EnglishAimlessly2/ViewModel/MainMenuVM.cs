﻿using EnglishAimlessly2.Model;
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

namespace EnglishAimlessly2.ViewModel
{
    public class MainMenuVM : INotifyPropertyChanged
    {
        private UserModel _loggedUser;
        private GroupModel _selectedGroup;
        private string _nextPracticeCounter;
        private string _groupName = "";
        private string _itemCount;
        private string _newWords;
        private int _masteredWordsCount = 0;
        private int _practiceAvailableCount;

        private DispatcherTimer _timer;
        private GroupModel nearestPracticeGroup;

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

        public string NextPracticeCounter
        {
            get
            {
                return _nextPracticeCounter;
            }
            set
            {
                _nextPracticeCounter = value;
                OnPropertyChanged(nameof(NextPracticeCounter));
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

        public int PracticeAvailableCount 
        { 
            get
            {
                return _practiceAvailableCount;
            }
            set
            {
                _practiceAvailableCount = value;
                OnPropertyChanged(nameof(PracticeAvailableCount));
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
                if(DesignerProperties.GetIsInDesignMode(new System.Windows.DependencyObject()) == false) ReloadGroups();
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
                GroupTableHelper helper = new GroupTableHelper(DatabaseHelper.DATABASE_PATH);
                GroupModel temp = value;
                if (temp != null)
                {
                    helper.Reload();
                    _selectedGroup = helper.SearchById(temp.Id);
                    UpdateInformationForGroup();
                    OnPropertyChanged(nameof(SelectedGroup));
                }
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
                OnPropertyChanged(nameof(MasterWordsCount));
            }
        }

        public ObservableCollection<GroupModel> Groups { get; set; }
        public CreateGroupCommand CreateGroupCmd { get; set; }
        public RemoveGroupCommand RemoveGroupCmd { get; set; }

        public MainMenuVM()
        {
            LoggedUser = new UserModel();
            CreateGroupCmd = new CreateGroupCommand(this);
            RemoveGroupCmd = new RemoveGroupCommand(this);
            Groups = new ObservableCollection<GroupModel>();
            if (DesignerProperties.GetIsInDesignMode(new System.Windows.DependencyObject()) == false)
            {
                _timer = new DispatcherTimer();
                _timer.Interval = new TimeSpan(10,0,0,0,0);
                _timer.Tick += _timer_Tick;

                ReloadGroups();
            }
        }

        private void _timer_Tick(object sender, EventArgs e)
        {
            _timer.Stop();

            if (nearestPracticeGroup == null) return;
            OnTime?.Invoke(this, nearestPracticeGroup);
        }

        //private void UpdateTimeInterval()
        //{
        //    _timer.Stop();
        //    UserTableHelper userHelper = new UserTableHelper(DatabaseHelper.DATABASE_PATH);
        //    nearestPracticeGroup = userHelper.MinPracticeTime(LoggedUser.Id);

        //    if (nearestPracticeGroup == null) return;

        //    GroupTableHelper helper = new GroupTableHelper(DatabaseHelper.DATABASE_PATH); 
        //    TimeModel nearestPracticeTime = helper.NextPractice(nearestPracticeGroup.Id);
        //    int seconds = ((int)nearestPracticeTime.Seconds >= 60) ? (int)nearestPracticeTime.Seconds : 60;
        //    _timer.Interval = new TimeSpan(0, 0, seconds);
        //    if(nearestPracticeTime.Seconds > 0) _timer.Start();
        //}

        //public void StopTimer()
        //{
        //    UpdateTimeInterval();
        //    _timer.Stop();
        //}

        //public void StartTimer()
        //{
        //    UpdateTimeInterval();
        //    _timer.Start();
        //}

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
            OnPropertyChanged(nameof(SelectedGroup));

            ReloadGroups();
        }

        void UpdateInformationForGroup()
        {
            WordTableHelper wordHelper = new WordTableHelper(DatabaseHelper.DATABASE_PATH);
            ItemCount = wordHelper.SearchByGroupId(SelectedGroup.Id).Count.ToString();
            NewWords = wordHelper.SearchWordsByPractice(SelectedGroup.Id, 0, false).Count.ToString();
            PracticeAvailableCount = wordHelper.GetSortedDueTime(SelectedGroup).Count;
            MasterWordsCount = wordHelper.GetListByScore(SelectedGroup.Id, 1000).Count;
            //UpdateTimeInterval();
            UpdateNextPracticeCounter();
        }

        private void UpdateNextPracticeCounter()
        {
            GroupTableHelper groupHelper = new GroupTableHelper(DatabaseHelper.DATABASE_PATH);
            TimeModel nextPractice = groupHelper.NextPractice(SelectedGroup.Id);
            if (nextPractice.Miliseconds <= 0) NextPracticeCounter = "Next practice is available";
            else
            {
                int days = (int)nextPractice.Days;
                int hours = (int)nextPractice.Hours - days * 24;
                int minutes = (int)nextPractice.Minutes - hours * 60;

                if (days > 1000000) NextPracticeCounter = string.Format("No practice available");
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
            GroupTableHelper groupHelper = new GroupTableHelper(DatabaseHelper.DATABASE_PATH);
            Groups.Clear();
            foreach (GroupModel item in groupHelper.SearchByUserId(LoggedUser.Id))
            {
                Groups.Add(item);
            }
            //UpdateTimeInterval();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public delegate void OnTimeHandler(object sender, GroupModel readyGroup);
        public event OnTimeHandler OnTime;
    }
}
