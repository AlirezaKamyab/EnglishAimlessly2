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
    public class PracticeVM : INotifyPropertyChanged
    {
        private int _selectedIndex = 0;
        private string _example = "";
        private WordModel _selectedWord;
        private GroupModel _selectedGroup;
        private SortedList<long, WordModel> _words;

        public string Example
        {
            get
            {
                return _example;
            }
            set
            {
                _example = value;
                OnPropertyChanged(nameof(Example));
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
                if(SelectedGroup != null) Reload();
                OnPropertyChanged(nameof(SelectedGroup));
            }
        }
        public WordModel SelectedWord
        {
            get
            {
                return _selectedWord;
            }
            set
            {
                _selectedWord = value;
                OnPropertyChanged(nameof(SelectedWord));
            }
        }

        public int SelectedIndex
        {
            get
            {
                return _selectedIndex;
            }
            set
            {
                if (value < _words.Values.Count)
                {
                    _selectedIndex = value;
                    SelectedWord = _words.Values[SelectedIndex];
                }
                else Completed?.Invoke(this);
            }
        }

        public int WordCount { get; set; } = 0;

        public WordTableHelper WordDatabaseHelper { get; set; }
        //public GroupTableHelper GroupDatabaseHelper { get; set; }
        public NextWordPracticeCommand NextWordPracticeCmd { get; set; }
        public PracticeVM()
        {
            if(!DesignerProperties.GetIsInDesignMode(new System.Windows.DependencyObject()))
            {
                WordDatabaseHelper = new WordTableHelper(DatabaseHelper.DATABASE_PATH);
                //GroupDatabaseHelper = new GroupTableHelper(DatabaseHelper.DATABASE_PATH);
            }

            // Commands
            NextWordPracticeCmd = new NextWordPracticeCommand(this);
        }

        private void Reload()
        {
            WordDatabaseHelper.Reload();
            _words = WordDatabaseHelper.GetSortedDueTime(SelectedGroup);

            WordCount = _words.Count;

            if (WordCount != 0)
            {
                SelectedIndex = 0;
                SelectedWord = _words.Values[SelectedIndex];
            }
        }

        public void NextWordEasy()
        {
            if (SelectedWord == null) return;

            double p = SelectedWord.PracticeCount; // Practice count for the function addHours
            double addHours = (0.75 * p * p * p) + (1 * p * p) + (8 * (p + 1));

            WordModel updateWord = SelectedWord;
            updateWord.UpdatedDate = DateTime.Now;
            updateWord.PracticeCount++;

            DateTime dueDate = DateTime.Now;
            dueDate = dueDate.AddHours(addHours);
            updateWord.DueDate = dueDate;

            WordDatabaseHelper.Update(updateWord);
            AddHistory(updateWord, 1);

            SelectedIndex++;

            GoneNext?.Invoke(this, SelectedWord);
        }

        public void NextWordNormal()
        {
            if (SelectedWord == null) return;

            double p = SelectedWord.PracticeCount; // Practice count for the function addHours
            double addHours = (2 * p * p) + (5 * (p + 1));

            WordModel updateWord = SelectedWord;
            updateWord.UpdatedDate = DateTime.Now;
            updateWord.PracticeCount++;

            DateTime dueDate = DateTime.Now;
            dueDate = dueDate.AddHours(addHours);
            updateWord.DueDate = dueDate;

            WordDatabaseHelper.Update(updateWord);
            AddHistory(updateWord, 2);

            SelectedIndex++;

            GoneNext?.Invoke(this, SelectedWord);
        }

        public void NextWordHard()
        {
            if (SelectedWord == null) return;

            int p = SelectedWord.PracticeCount; // Practice count for the function addHours
            double addHours = (1 * p * p) + (5 * (p + 1));

            WordModel updateWord = SelectedWord;
            updateWord.UpdatedDate = DateTime.Now;
            updateWord.PracticeCount++;

            DateTime dueDate = DateTime.Now;
            dueDate = dueDate.AddHours(addHours);
            updateWord.DueDate = dueDate;

            WordDatabaseHelper.Update(updateWord);
            AddHistory(updateWord, 3);

            SelectedIndex++;

            GoneNext?.Invoke(this, SelectedWord);
        }

        public void AddHistory(WordModel word, int difficultyLevel)
        {
            HistoryTableHelper historyHelper = new HistoryTableHelper(DatabaseHelper.DATABASE_PATH);
            HistoryModel history = new HistoryModel();
            history.WordId = word.Id;
            history.UserId = word.UserId;
            history.GroupId = word.GroupId;
            history.Word = word.Name;
            history.PracticedDate = DateTime.Now;
            history.Example = Example;
            history.DifficultyLevel = difficultyLevel;
            history.WordType = word.WordType;

            Example = ""; // Reset the value of the example property for the next word

            historyHelper.Insert(history);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public delegate void NextHandler(object sender, WordModel word);
        public delegate void UpdateHandler(object sender);
        public event NextHandler GoneNext;
        public event UpdateHandler Completed;
    }
}
