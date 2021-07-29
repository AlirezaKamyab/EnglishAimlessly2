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
    public class HistoryVM : INotifyPropertyChanged
    {
        private int _wordId = -1;
        private int _groupId = -1;
        private string _wordName;
        private HistoryModel _selectedHistory;
        private HistoryModel _selectedGroupHistory;
        private HistoryTableHelper _historyTableHelper;

        public int WordId
        {
            get
            {
                return _wordId;
            }
            set
            {
                if (value > 0)
                {
                    _wordId = value;
                    Reload();
                    OnPropertyChanged(nameof(WordId));
                }
            }
        }

        public string WordName
        {
            get
            {
                return _wordName;
            }
            set
            {
                _wordName = value;
                OnPropertyChanged(nameof(WordName));
            }
        }

        public int GroupId
        {
            get
            {
                return _groupId;
            }
            set
            {
                if (value > 0)
                {
                    _groupId = value;
                    Reload();
                    OnPropertyChanged(nameof(GroupId));
                }
            }
        }

        public HistoryModel SelectedHistory
        {
            get
            {
                return _selectedHistory;
            }
            set
            {
                _selectedHistory = value;
                OnPropertyChanged(nameof(SelectedHistory));
            }
        }

        public HistoryModel SelectedGroupHistory
        {
            get
            {
                return _selectedGroupHistory;
            }
            set
            {
                _selectedGroupHistory = value;
                OnPropertyChanged(nameof(SelectedGroupHistory));
            }
        }

        public ObservableCollection<HistoryModel> Histories { get; set; }
        public ObservableCollection<HistoryModel> GroupHistories { get; set; }
        public RemoveHistoryCommand RemoveHistoryCmd { get; set; }

        public HistoryVM()
        {
            Histories = new ObservableCollection<HistoryModel>();
            GroupHistories = new ObservableCollection<HistoryModel>();
            if (!DesignerProperties.GetIsInDesignMode(new System.Windows.DependencyObject()))
            {
                _historyTableHelper = new HistoryTableHelper(DatabaseHelper.DATABASE_PATH);
            }

            // Commands
            RemoveHistoryCmd = new RemoveHistoryCommand(this);
        }

        public void Reload()
        {
            _historyTableHelper.Reload();
            Histories.Clear();
            GroupHistories.Clear();

            if (WordId > 0)
            {
                foreach (HistoryModel item in _historyTableHelper.SearchHistoryByWordId(WordId))
                {
                    Histories.Add(item);
                }

                WordTableHelper helper = new WordTableHelper(DatabaseHelper.DATABASE_PATH);
                WordName = helper.SearchById(WordId).Name;
            }

            if (GroupId > 0)
            {
                foreach (HistoryModel item in _historyTableHelper.SearchHistoryByGroupId(GroupId))
                {
                    GroupHistories.Add(item);
                }
            }
        }

        public void DeleteHistory()
        {
            HistoryModel history = new HistoryModel();
            history.Id = SelectedHistory.Id;
            _historyTableHelper.Remove(history);
            Reload();
        }

        public void DeleteGroupHistory()
        {
            HistoryModel groupHistory = new HistoryModel();
            groupHistory.Id = SelectedGroupHistory.Id;
            _historyTableHelper.Remove(groupHistory);
            Reload();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
