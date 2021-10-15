using EnglishAimlessly2.Model;
using EnglishAimlessly2.View;
using EnglishAimlessly2.ViewModel.Base;
using EnglishAimlessly2.ViewModel.Commands;
using EnglishAimlessly2.ViewModel.Commands.Manager;
using EnglishAimlessly2.ViewModel.Helper;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace EnglishAimlessly2.ViewModel
{
    public class ManagerVM : BaseVM
    {
        private UserModel _loggedUser;
        private GroupModel _selectedGroup;
        private WordModel _selectedWord;
        private string _searchWordName;

        private string _wordName;
        private string _wordType;
        private string _equivalent;
        private string _description;

        // Direct Design
        private Visibility _mainPanelVisibility = Visibility.Collapsed;

        public static MainViewVM MainViewModel { get; set; }

        public UserModel LoggedUser
        {
            get
            {
                return _loggedUser;
            }
            set
            {
                _loggedUser = value;
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
                _selectedGroup = value;
                if (!DesignerProperties.GetIsInDesignMode(new System.Windows.DependencyObject()) && SelectedGroup != null && WordList != null && SelectedWord != null) Reload();
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
                if(value != null && value.Id > 0)
                {
                    MainPanelVisibility = Visibility.Visible;
                }
                else
                {
                    MainPanelVisibility = Visibility.Collapsed;
                }
                _selectedWord = value;
                onPropertyChanged(nameof(SelectedWord));
                onPropertyChanged(nameof(LastPracticed));
            }
        }

        public string SearchWordName
        {
            get
            {
                return _searchWordName;
            }
            set
            {
                _searchWordName = value;
                onPropertyChanged(nameof(SearchWordName));
                if (SelectedGroup == null) return;
                FilterWords();
            }
        }

        public string LastPracticed
        {
            get
            {
                int days = (int)DateTimeHelper.LastPracticeSpan(SelectedWord).Days;
                int hours = (int)DateTimeHelper.LastPracticeSpan(SelectedWord).Hours;
                if (days == 0) return string.Format("{0} hours ago", hours);
                else return string.Format("{0} days ago", days);
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

        public string WordType
        {
            get
            {
                return _wordType;
            }
            set
            {
                _wordType = value;
                onPropertyChanged(nameof(WordType));
            }
        }

        public string Equivalent
        {
            get
            {
                return _equivalent;
            }
            set
            {
                _equivalent = value;
                onPropertyChanged(nameof(Equivalent));
            }
        }

        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
                onPropertyChanged(nameof(Description));
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

        public ObservableCollection<WordModel> WordList { get; set; }
        public AddWordCommand AddWordCmd { get; set; }
        public EditWordCommand EditWordCmd { get; set; }
        public RemoveWordCommand RemoveWordCmd { get; set; }
        public ResetWordCommand ResetWordCmd { get; set; }
        public OpenManagerWindowsCommand OpenManagerWindowsCmd { get; set; }
        public CloseManagerToMainMenuCommand CloseToMainMenuCmd { get; set; }
        public ManagerVM()
        {
            WordList = new ObservableCollection<WordModel>();
            LoggedUser = new UserModel();
            SelectedGroup = new GroupModel();
            SelectedWord = new WordModel();

            if (!DesignerProperties.GetIsInDesignMode(new System.Windows.DependencyObject()))
            {

            }

            if(MainViewModel != null)
            {
                SelectedGroup = MainViewModel.SelectedGroup;
            }

            // Commands
            AddWordCmd = new AddWordCommand(this);
            EditWordCmd = new EditWordCommand(this);
            RemoveWordCmd = new RemoveWordCommand(this);
            ResetWordCmd = new ResetWordCommand(this);
            OpenManagerWindowsCmd = new OpenManagerWindowsCommand(this);
            CloseToMainMenuCmd = new CloseManagerToMainMenuCommand();
        }

        public void Reload()
        {
            WordTableHelper WordDatabaseHelper = new WordTableHelper(DatabaseHelper.DATABASE_PATH);
            WordList.Clear();
            foreach(WordModel item in WordDatabaseHelper.SearchByGroupId(SelectedGroup.Id).OrderBy(x => x.Name))
            {
                WordList.Add(item);
            }
            //SelectedWord = null;
        }

        public void FilterWords()
        {
            WordTableHelper WordDatabaseHelper = new WordTableHelper(DatabaseHelper.DATABASE_PATH);
            WordList.Clear();
            foreach (WordModel item in WordDatabaseHelper.SearchByGroupId(SelectedGroup.Id).OrderBy(x => x.Name))
            {
                if(item.Name.ToLower().Trim().Contains(SearchWordName.Trim().ToLower())) WordList.Add(item);
            }
            //SelectedWord = null;
        }

        public void AddWord()
        {
            WordTableHelper WordDatabaseHelper = new WordTableHelper(DatabaseHelper.DATABASE_PATH);
            WordModel word = new WordModel();
            word.Name = WordName;
            word.WordType = WordType;
            word.Equivalent = Equivalent;
            word.Description = Description;
            word.CreationDate = DateTime.Now;
            word.DueDate = DateTime.Now;
            word.UpdatedDate = DateTime.Now;
            word.PracticeCount = 0;
            word.UserId = LoggedUser.Id;
            word.GroupId = SelectedGroup.Id;
            word.Score = 0;
            WordDatabaseHelper.Insert(word);
        }

        public void EditWord()
        {
            WordTableHelper WordDatabaseHelper = new WordTableHelper(DatabaseHelper.DATABASE_PATH);
            WordModel word = new WordModel();
            word.Id = SelectedWord.Id;
            word.Name = WordName;
            word.WordType = WordType;
            word.Equivalent = Equivalent;
            word.Description = Description;
            word.CreationDate = SelectedWord.CreationDate;
            word.DueDate = SelectedWord.DueDate;
            word.UpdatedDate = SelectedWord.UpdatedDate;
            word.PracticeCount = SelectedWord.PracticeCount;
            word.UserId = SelectedWord.UserId;
            word.GroupId = SelectedWord.GroupId;
            word.Score = SelectedWord.Score;
            WordDatabaseHelper.Update(word);
        }

        public void RemoveWord()
        {
            WordTableHelper WordDatabaseHelper = new WordTableHelper(DatabaseHelper.DATABASE_PATH);
            WordModel word = new WordModel();
            word.Id = SelectedWord.Id;
            word.Name = SelectedWord.Name;
            word.WordType = SelectedWord.WordType;
            word.Equivalent = SelectedWord.Equivalent;
            word.Description = SelectedWord.Description;
            word.CreationDate = SelectedWord.CreationDate;
            word.DueDate = SelectedWord.DueDate;
            word.UpdatedDate = SelectedWord.UpdatedDate;
            word.PracticeCount = SelectedWord.PracticeCount;
            word.UserId = SelectedWord.UserId;
            word.GroupId = SelectedWord.GroupId;
            word.Score = SelectedWord.Score;
            WordDatabaseHelper.Remove(word);
        }

        public void ResetWord()
        {
            WordTableHelper WordDatabaseHelper = new WordTableHelper(DatabaseHelper.DATABASE_PATH);
            WordModel word = new WordModel();
            word.Id = SelectedWord.Id;
            word.Name = SelectedWord.Name;
            word.WordType = SelectedWord.WordType;
            word.Equivalent = SelectedWord.Equivalent;
            word.Description = SelectedWord.Description;
            word.CreationDate = DateTime.Now;
            word.DueDate = DateTime.Now;
            word.UpdatedDate = DateTime.Now;
            word.PracticeCount = 0;
            word.UserId = SelectedWord.UserId;
            word.GroupId = SelectedWord.GroupId;
            word.Score = 0;
            WordDatabaseHelper.Update(word);
        }

        public void OpenAdd()
        {
            WordName = "";
            WordType = "";
            Equivalent = "";
            Description = "";

            AddWordView awv = new AddWordView(this);
            awv.ShowDialog();
            Reload();
        }

        public void OpenAddTogether()
        {
            AddTogetherView atv = new AddTogetherView(this);
            atv.ShowDialog();
            Reload();
        }

        public void OpenEdit()
        {
            WordName = SelectedWord.Name;
            WordType = SelectedWord.WordType;
            Description = SelectedWord.Description;
            Equivalent = SelectedWord.Equivalent;

            EditWordView ewv = new EditWordView(this);
            ewv.ShowDialog();
            Reload();
        }

        public void OpenGroupSettings()
        {
            GroupSettingsView hv = new GroupSettingsView(SelectedGroup);
            hv.ShowDialog();
            Reload();
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
