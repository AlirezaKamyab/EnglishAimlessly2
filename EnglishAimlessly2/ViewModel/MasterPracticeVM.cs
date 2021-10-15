using EnglishAimlessly2.Model;
using EnglishAimlessly2.ViewModel.Base;
using EnglishAimlessly2.ViewModel.Commands;
using EnglishAimlessly2.ViewModel.Commands.MasterPractice;
using EnglishAimlessly2.ViewModel.Helper;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace EnglishAimlessly2.ViewModel
{
    public class MasterPracticeVM : BaseVM, INotifyPropertyChanged
    {
        private SolidColorBrush _mainBackGround = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
        private SolidColorBrush _green = new SolidColorBrush(Color.FromArgb(255, 40, 200, 40));
        private SolidColorBrush _red = new SolidColorBrush(Color.FromArgb(255, 255, 80, 80));

        const string HIDDEN_ANSWER = "";

        private GroupModel _group;
        private string _answer = "";
        private WordModel _selectedWord;
        private int _currentIndex = 0;
        private string _solutionWord = HIDDEN_ANSWER;
        private string _solutionType = HIDDEN_ANSWER;

        // Direct control
        private bool _checkAnswerButtonEnable = true;
        private bool _revealButtonEnabled = true;
        private SolidColorBrush _backgroundColor;
        private SolidColorBrush _answerColor;
        private Visibility _mainPanelVisibility = Visibility.Visible;
        private Visibility _errorVisibility = Visibility.Collapsed;

        public static MainViewVM MainViewModel { get; set; }
        public SolidColorBrush BackgroundColor
        {
            get { return _backgroundColor; }
            set
            {
                _backgroundColor = value;
                onPropertyChanged(nameof(BackgroundColor));
            }
        }
        public SolidColorBrush AnswerColor
        {
            get {  return _answerColor; }
            set
            {
                _answerColor = value;
                onPropertyChanged(nameof(AnswerColor));
            }
        }
        public Visibility MainPanelVisibility
        {
            get {  return _mainPanelVisibility; }
            set
            {
                _mainPanelVisibility = value;
                onPropertyChanged(nameof(MainPanelVisibility));
            }
        }
        public Visibility ErrorVisibility
        {
            get {  return _errorVisibility; }
            set
            {
                _errorVisibility = value;
                onPropertyChanged(nameof(ErrorVisibility));
            }
        }
        public string SolutionWord
        {
            get { return _solutionWord; }
            set
            {
                _solutionWord = value;
                onPropertyChanged(nameof(SolutionWord));
            }
        }
        public bool RevealButtonEnabled
        {
            get { return _revealButtonEnabled; }
            set
            {
                _revealButtonEnabled = value;
                onPropertyChanged(nameof(RevealButtonEnabled));
            }
        }
        public int CurrentIndex
        {
            get {  return _currentIndex; }
            set
            {
                if (WordsList.Count == 0)
                {
                    MainPanelVisibility = Visibility.Collapsed;
                    ErrorVisibility = Visibility.Visible;
                    return;
                }
                else if (value > WordsList.Count - 1)
                {
                    MainPanelVisibility = Visibility.Collapsed;
                    ErrorVisibility = Visibility.Visible;
                    return;
                }

                _currentIndex = value;
                SelectedWord = WordsList[CurrentIndex];
            }
        }
        public string SolutionType
        {
            get { return _solutionType; }
            set
            {
                _solutionType = value;
                onPropertyChanged(nameof(SolutionType));
            }
        }
        public WordModel SelectedWord
        {
            get { return _selectedWord; }
            set 
            {
                _selectedWord = value; 
                onPropertyChanged(nameof(SelectedWord));
            }
        }
        public string Answer
        {
            get { return _answer; }
            set
            {
                _answer = value;
                onPropertyChanged(nameof(Answer));
            }
        }
        public bool CheckAnswerButtonEnable 
        {
            get { return _checkAnswerButtonEnable; }
            set
            {
                _checkAnswerButtonEnable = value;
                onPropertyChanged(nameof(CheckAnswerButtonEnable));
            }
        }
        public GroupModel Group
        {
            get { return _group; }
            set 
            {
                if(value != null)
                {
                    _group = value;
                    if(_group != null) Reload();
                }
            }
        }

        public ObservableCollection<WordModel> WordsList { get; set; }

        public MasterPracticeRevealCommand RevealCmd { get; set; }
        public MasterPracticeSkip SkipCmd { get; set; }
        public CheckMasterPracticeAnswerCommand CheckAnswerCmd { get; set; }
        public CloseMasterPracticeToMainMenuCommand CloseMasterPracticeCmd { get; set; }

        public MasterPracticeVM ()
        {
            CheckAnswerCmd = new CheckMasterPracticeAnswerCommand(this);
            SkipCmd = new MasterPracticeSkip(this);
            RevealCmd = new MasterPracticeRevealCommand(this);
            CloseMasterPracticeCmd = new CloseMasterPracticeToMainMenuCommand();
            WordsList = new ObservableCollection<WordModel>();

            BackgroundColor = _mainBackGround;
            Group = MainViewModel.SelectedGroup;
            AnswerColor = _red;
        }

        private void Reload()
        {
            WordsList.Clear();
            WordTableHelper helper = new WordTableHelper(DatabaseHelper.DATABASE_PATH);
            foreach (WordModel word in helper.GetSortedMasterPracticeTime(_group, 1000))
            {
                WordsList.Add(word);
            }

            CurrentIndex = 0;
        }

        public void CheckAnswer()
        {
            WordTableHelper helper = new WordTableHelper(DatabaseHelper.DATABASE_PATH);
            if(Answer.ToLower() == SelectedWord.Name.ToLower())
            {
                WordModel newUpdate = SelectedWord;
                newUpdate.Score += 100;
                newUpdate.MasterLastPractice = DateTime.Now;
                helper.Update(newUpdate);
                SolutionWord = SelectedWord.Name;
                SolutionType = SelectedWord.WordType;
                Answer = "";
                RevealButtonEnabled = false;
                CheckAnswerButtonEnable = false;
                //BackgroundColor = _green;
                AnswerColor = _green;
            }
            else
            {
                RevealAnswer();
                //BackgroundColor = _red;
            }
        }

        public void RevealAnswer()
        {
            SolutionWord = SelectedWord.Name;
            SolutionType = SelectedWord.WordType;
            CheckAnswerButtonEnable = false;
            RevealButtonEnabled = false;
            AnswerColor = _green;
            
            WordTableHelper helper = new WordTableHelper(DatabaseHelper.DATABASE_PATH);
            WordModel newUpdate = SelectedWord;
            newUpdate.Score -= 100;
            newUpdate.MasterLastPractice = DateTime.Now;
            helper.Update(newUpdate);

            SelectedWord = newUpdate;
        }

        public void Skip()
        {
            if (CurrentIndex < WordsList.Count - 1) CurrentIndex++;
            else
            {
                CurrentIndex++;
                return;
            }

            SolutionWord = HIDDEN_ANSWER;
            SolutionType = HIDDEN_ANSWER;
            Answer = "";
            RevealButtonEnabled = true;
            CheckAnswerButtonEnable = true;
            //BackgroundColor = _mainBackGround;
            AnswerColor = _red;
        }
    }
}
