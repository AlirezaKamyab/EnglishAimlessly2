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
    public class ManagerVM : INotifyPropertyChanged
    {
        private UserModel _loggedUser;
        private GroupModel _selectedGroup;
        private WordModel _selectedWord;
        private string _searchWordName;

        private string _wordName;
        private string _wordType;
        private string _equivalent;
        private string _description;

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
                if (!DesignerProperties.GetIsInDesignMode(new System.Windows.DependencyObject()) && SelectedGroup != null && WordList != null && SelectedWord != null) Reload();
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
                SelectionWordChanged?.Invoke(this);
                OnPropertyChanged(nameof(SelectedWord));
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
                OnPropertyChanged(nameof(SearchWordName));
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

        public string WordType
        {
            get
            {
                return _wordType;
            }
            set
            {
                _wordType = value;
                OnPropertyChanged(nameof(WordType));
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
                OnPropertyChanged(nameof(Equivalent));
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
                OnPropertyChanged(nameof(Description));
            }
        }

        public WordModel SelectedWordForFunctioning { get; set; }

        private WordTableHelper _wordHelper;
        public ObservableCollection<WordModel> WordList { get; set; }
        public AddWordCommand AddWordCmd { get; set; }
        public EditWordCommand EditWordCmd { get; set; }
        public RemoveWordCommand RemoveWordCmd { get; set; }
        public ResetWordCommand ResetWordCmd { get; set; }
        public ManagerVM()
        {
            WordList = new ObservableCollection<WordModel>();
            LoggedUser = new UserModel();
            SelectedGroup = new GroupModel();
            SelectedWord = new WordModel();

            if (!DesignerProperties.GetIsInDesignMode(new System.Windows.DependencyObject()))
            {
                _wordHelper = new WordTableHelper(DatabaseHelper.DATABASE_PATH);
            }

            // Commands
            AddWordCmd = new(this);
            EditWordCmd = new(this);
            RemoveWordCmd = new(this);
            ResetWordCmd = new(this);
        }

        public void Reload()
        {
            _wordHelper.Reload();
            WordList.Clear();
            foreach(WordModel item in _wordHelper.SearchByGroupId(SelectedGroup.Id))
            {
                WordList.Add(item);
            }
        }

        public void AddWord()
        {
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
            _wordHelper.Insert(word);

            Added?.Invoke(this, word);
        }

        public void EditWord()
        {
            WordModel word = new WordModel();
            word.Id = SelectedWordForFunctioning.Id;
            word.Name = WordName;
            word.WordType = WordType;
            word.Equivalent = Equivalent;
            word.Description = Description;
            word.CreationDate = SelectedWordForFunctioning.CreationDate;
            word.DueDate = SelectedWordForFunctioning.DueDate;
            word.UpdatedDate = SelectedWordForFunctioning.UpdatedDate;
            word.PracticeCount = SelectedWordForFunctioning.PracticeCount;
            word.UserId = SelectedWordForFunctioning.UserId;
            word.GroupId = SelectedWordForFunctioning.GroupId;
            _wordHelper.Update(word);

            Edited?.Invoke(this, word);
        }

        public void RemoveWord()
        {
            WordModel word = new WordModel();
            word.Id = SelectedWordForFunctioning.Id;
            word.Name = SelectedWordForFunctioning.Name;
            word.WordType = SelectedWordForFunctioning.WordType;
            word.Equivalent = SelectedWordForFunctioning.Equivalent;
            word.Description = SelectedWordForFunctioning.Description;
            word.CreationDate = SelectedWordForFunctioning.CreationDate;
            word.DueDate = SelectedWordForFunctioning.DueDate;
            word.UpdatedDate = SelectedWordForFunctioning.UpdatedDate;
            word.PracticeCount = SelectedWordForFunctioning.PracticeCount;
            word.UserId = SelectedWordForFunctioning.UserId;
            word.GroupId = SelectedWordForFunctioning.GroupId;
            _wordHelper.Remove(word);

            Removed?.Invoke(this, word);
        }

        public void ResetWord()
        {
            WordModel word = new WordModel();
            word.Id = SelectedWordForFunctioning.Id;
            word.Name = SelectedWordForFunctioning.Name;
            word.WordType = SelectedWordForFunctioning.WordType;
            word.Equivalent = SelectedWordForFunctioning.Equivalent;
            word.Description = SelectedWordForFunctioning.Description;
            word.CreationDate = DateTime.Now;
            word.DueDate = DateTime.Now;
            word.UpdatedDate = DateTime.Now;
            word.PracticeCount = 0;
            word.UserId = SelectedWordForFunctioning.UserId;
            word.GroupId = SelectedWordForFunctioning.GroupId;
            _wordHelper.Update(word);

            Edited?.Invoke(this, word);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public delegate void AddHandler(object sender, WordModel addedWord);
        public delegate void EditHandler(object sender, WordModel newWord);
        public delegate void RemoveHandler(object sender, WordModel removedWord);
        public delegate void UpdateControlHandler(object sender);

        public event AddHandler Added;
        public event EditHandler Edited;
        public event RemoveHandler Removed;
        public event UpdateControlHandler SelectionWordChanged;
    }
}
