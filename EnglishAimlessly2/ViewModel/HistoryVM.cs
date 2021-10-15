using EnglishAimlessly2.Model;
using EnglishAimlessly2.ViewModel.Base;
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
    public class HistoryVM : BaseVM, INotifyPropertyChanged
    {
        private int _wordId = -1;
        private int _groupId = -1;
        private string _wordName;
        private HistoryModel _selectedHistory;
        private HistoryTableHelper _historyTableHelper;
        private DateTime _practicedDateTime;
        private System.Windows.Visibility _datePickerVisibility = System.Windows.Visibility.Collapsed;

        public static MainViewVM MainViewModel { get; set; }

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
                    DatePickerVisibility = System.Windows.Visibility.Collapsed;
                    Reload();
                    onPropertyChanged(nameof(WordId));
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
                onPropertyChanged(nameof(WordName));
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
                    DatePickerVisibility = System.Windows.Visibility.Visible;
                    Reload();
                    onPropertyChanged(nameof(GroupId));
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
                onPropertyChanged(nameof(SelectedHistory));
            }
        }

        public DateTime PracticedDateTime
        {
            get
            {
                return _practicedDateTime;
            }
            set
            {
                _practicedDateTime = value;
                Reload();
                onPropertyChanged(nameof(PracticedDateTime));
            }
        }

        public System.Windows.Visibility DatePickerVisibility
        {
            get
            {
                return _datePickerVisibility;
            }
            set
            {
                _datePickerVisibility = value;
                onPropertyChanged(nameof(DatePickerVisibility));
            }
        }

        public ObservableCollection<HistoryModel> Histories { get; set; }
        public RemoveHistoryCommand RemoveHistoryCmd { get; set; }

        public HistoryVM()
        {
            Histories = new ObservableCollection<HistoryModel>();
            if (!DesignerProperties.GetIsInDesignMode(new System.Windows.DependencyObject()))
            {
                _historyTableHelper = new HistoryTableHelper(DatabaseHelper.DATABASE_PATH);
                PracticedDateTime = DateTime.Now;
            }

            if (MainViewModel.SelectedGroup != null) GroupId = MainViewModel.SelectedGroup.Id;
            if (MainViewModel.SelectedWord != null) WordId = MainViewModel.SelectedWord.Id;
            // Commands
            RemoveHistoryCmd = new RemoveHistoryCommand(this);
        }

        public void Reload()
        {
            _historyTableHelper.Reload();
            Histories.Clear();

            if (WordId > 0)
            {
                foreach (HistoryModel item in _historyTableHelper.SearchHistoryByWordId(WordId))
                {
                    Histories.Add(item);
                }

                WordTableHelper helper = new WordTableHelper(DatabaseHelper.DATABASE_PATH);
                WordName = helper.SearchById(WordId).Name;
            }
            else if (GroupId > 0)
            {
                List<HistoryModel> result = _historyTableHelper.SearchHistoryByDate(GroupId, PracticedDateTime);
                result.Reverse();
                foreach (HistoryModel item in result)
                {
                    Histories.Add(item);
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
    }
}
