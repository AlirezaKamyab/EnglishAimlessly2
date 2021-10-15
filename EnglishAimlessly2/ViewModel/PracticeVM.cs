using EnglishAimlessly2.Model;
using EnglishAimlessly2.View;
using EnglishAimlessly2.ViewModel.Base;
using EnglishAimlessly2.ViewModel.Commands;
using EnglishAimlessly2.ViewModel.Commands.Practice;
using EnglishAimlessly2.ViewModel.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace EnglishAimlessly2.ViewModel
{
    public class PracticeVM : BaseVM, INotifyPropertyChanged
    {
        private int _selectedIndex = 0;
        private string _example = "";
        private WordModel _selectedWord;
        private GroupModel _selectedGroup;
        private SortedList<long, WordModel> _words;

        // Direct design properties
        private Visibility _errorPanelVisibility = Visibility.Collapsed;
        private Visibility _controlsPanelVisibility = Visibility.Visible;
        private Visibility _showButtonVisibility = Visibility.Visible;
        private Visibility _answerVisibility = Visibility.Collapsed;

        public static MainViewVM MainViewModel { get; set; }
        public string Example
        {
            get
            {
                return _example;
            }
            set
            {
                _example = value;
                onPropertyChanged(nameof(Example));
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
                onPropertyChanged(nameof(SelectedGroup));
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
                onPropertyChanged(nameof(SelectedWord));
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
                else
                {
                    ErrorPanelVisibility = Visibility.Visible;
                    ControlPanelVisibility = Visibility.Collapsed;
                }
            }
        }
        public Visibility ErrorPanelVisibility
        {
            get {  return _errorPanelVisibility; }
            set
            {
                _errorPanelVisibility = value;
                onPropertyChanged(nameof(ErrorPanelVisibility));
            }
        }
        public Visibility ControlPanelVisibility
        {
            get { return _controlsPanelVisibility; }
            set
            {
                _controlsPanelVisibility = value;
                onPropertyChanged(nameof(ControlPanelVisibility));
            }
        }

        public Visibility ShowButtonVisibility
        {
            get { return _showButtonVisibility; }
            set
            {
                _showButtonVisibility = value;
                onPropertyChanged(nameof(ShowButtonVisibility));
            }
        }

        public Visibility AnswerVisibility
        {
            get { return _answerVisibility; }
            set
            {
                _answerVisibility = value;
                onPropertyChanged(nameof(AnswerVisibility));
            }
        }

        public int WordCount { get; set; } = 0;

        public NextWordPracticeCommand NextWordPracticeCmd { get; set; }
        public ClosePracticeToMainMenuCommand ClosePracticeCmd { get; set; }
        public OpenHistoryCommand OpenHistoryCmd {  get; set; }
        public ShowAnswerCommand ShowAnswerCmd { get; set; }
        public PracticeVM()
        {
            // Commands
            NextWordPracticeCmd = new NextWordPracticeCommand(this);
            ClosePracticeCmd = new ClosePracticeToMainMenuCommand();
            OpenHistoryCmd = new OpenHistoryCommand(this);
            ShowAnswerCmd = new ShowAnswerCommand(this);
            SelectedGroup = MainViewModel.SelectedGroup;
        }

        private void Reload()
        {
            WordTableHelper WordDatabaseHelper = new WordTableHelper(DatabaseHelper.DATABASE_PATH);
            _words = WordDatabaseHelper.GetSortedDueTime(SelectedGroup);

            WordCount = _words.Count;

            if (WordCount != 0)
            {
                SelectedIndex = 0;
                SelectedWord = _words.Values[SelectedIndex];

                ControlPanelVisibility = Visibility.Visible;
                ErrorPanelVisibility = Visibility.Collapsed;
            }
            else
            {
                ControlPanelVisibility = Visibility.Collapsed;
                ErrorPanelVisibility = Visibility.Visible;
            }
        }

        public void NextWordEasy()
        {
            if (SelectedWord == null) return;

            WordTableHelper WordDatabaseHelper = new WordTableHelper(DatabaseHelper.DATABASE_PATH);
            int score = SelectedWord.Score + 100;
            int checkpoint = SelectedWord.CheckPointScore;
            double s = (score - checkpoint)  / 100;  // Scores / 100
            double addHours = (0.8 * s * s / 2) + (6 * s) + 5;

            WordModel updateWord = SelectedWord;
            updateWord.UpdatedDate = DateTime.Now;
            updateWord.PracticeCount++;

            DateTime dueDate = DateTime.Now;
            dueDate = dueDate.AddHours(addHours);
            updateWord.DueDate = dueDate;

            int exampleScore = (Example.Trim().Length >= 5) ? 5 : 0;
            updateWord.Score += 100 + exampleScore;

            WordDatabaseHelper.Update(updateWord);
            AddHistory(updateWord, 1, score);

            SelectedIndex++;

            AnswerVisibility = Visibility.Collapsed;
            ShowButtonVisibility = Visibility.Visible;
        }

        public void NextWordNormal()
        {
            WordTableHelper WordDatabaseHelper = new WordTableHelper(DatabaseHelper.DATABASE_PATH);
            if (SelectedWord == null) return;

            int score = SelectedWord.Score + 75;
            int checkpoint = SelectedWord.CheckPointScore;
            double s = (score - checkpoint) / 100;  // Scores / 100
            double addHours = (0.95 * s * s / 3) + (3 * s) + 7;

            WordModel updateWord = SelectedWord;
            updateWord.UpdatedDate = DateTime.Now;
            updateWord.PracticeCount++;

            DateTime dueDate = DateTime.Now;
            dueDate = dueDate.AddHours(addHours);
            updateWord.DueDate = dueDate;

            int exampleScore = (Example.Trim().Length >= 5) ? 5 : 0;
            updateWord.Score += 75 + exampleScore;

            WordDatabaseHelper.Update(updateWord);
            AddHistory(updateWord, 2, score);

            SelectedIndex++;

            AnswerVisibility = Visibility.Collapsed;
            ShowButtonVisibility = Visibility.Visible;
        }

        public void NextWordHard()
        {
            if (SelectedWord == null) return;
            WordTableHelper WordDatabaseHelper = new WordTableHelper(DatabaseHelper.DATABASE_PATH);

            int score = SelectedWord.Score + 50;
            int checkpoint = SelectedWord.CheckPointScore;
            double s = (score - checkpoint) / 100;  // Scores / 100
            double addHours = (1 * s * s / 4) + (4 * (s)) + 10;

            WordModel updateWord = SelectedWord;
            updateWord.UpdatedDate = DateTime.Now;
            updateWord.PracticeCount++;

            DateTime dueDate = DateTime.Now;
            dueDate = dueDate.AddHours(addHours);
            updateWord.DueDate = dueDate;

            int exampleScore = (Example.Trim().Length >= 5) ? 5 : 0;
            updateWord.Score += 50 + exampleScore;

            WordDatabaseHelper.Update(updateWord);
            AddHistory(updateWord, 3, score);

            SelectedIndex++;

            AnswerVisibility = Visibility.Collapsed;
            ShowButtonVisibility = Visibility.Visible;
        }

        public void NextHours()
        {
            if (SelectedWord == null) return;
            WordTableHelper WordDatabaseHelper = new WordTableHelper(DatabaseHelper.DATABASE_PATH);

            Random random = new Random();
            double addHours = random.Next(1, 25);

            WordModel updateWord = SelectedWord;
            updateWord.UpdatedDate = DateTime.Now;
            updateWord.PracticeCount++;

            int exampleScore = (Example.Trim().Length >= 5) ? 5 : 0;
            updateWord.Score += 0 + exampleScore;

            DateTime dueDate = DateTime.Now;
            dueDate = dueDate.AddHours(addHours);
            updateWord.DueDate = dueDate;

            WordDatabaseHelper.Update(updateWord);
            AddHistory(updateWord, 4, updateWord.Score);

            SelectedIndex++;

            AnswerVisibility = Visibility.Collapsed;
            ShowButtonVisibility = Visibility.Visible;
        }

        public void AddHistory(WordModel word, int difficultyLevel, int score)
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

        public void OpenHistory()
        {
            MainViewModel.SelectedWord = SelectedWord;
            MainViewModel.SelectedGroup = null;
            HistoryVM.MainViewModel = MainViewModel;
            HistoryView whv = new HistoryView();
            whv.ShowDialog();
        }
    }
}
