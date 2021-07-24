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
        private WordModel _selectedWord;
        private GroupModel _selectedGroup;
        private SortedList<long, WordModel> _words;

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
                else Reload();
            }
        }

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
            NextWordPracticeCmd = new(this);
        }

        private void Reload()
        {
            WordDatabaseHelper.Reload();
            _words = WordDatabaseHelper.GetSortedDueTime(SelectedGroup);

            if (_words.Values.Count != 0)
            {
                SelectedIndex = 0;
                SelectedWord = _words.Values[SelectedIndex];
            }
        }

        public void NextWordEasy()
        {
            double p = SelectedWord.PracticeCount; // Practice count for the function addHours
            double addHours = (0.75 * p * p * p) + (1 * p * p) + (8 * (p + 1));

            WordModel updateWord = SelectedWord;
            updateWord.UpdatedDate = DateTime.Now;
            updateWord.PracticeCount++;

            DateTime dueDate = DateTime.Now;
            dueDate = dueDate.AddHours(addHours);
            updateWord.DueDate = dueDate;

            WordDatabaseHelper.Update(updateWord);

            SelectedIndex++;

            GoneNext?.Invoke(this, SelectedWord);
        }

        public void NextWordNormal()
        {
            double p = SelectedWord.PracticeCount; // Practice count for the function addHours
            double addHours = (2 * p * p) + (5 * (p + 1));

            WordModel updateWord = SelectedWord;
            updateWord.UpdatedDate = DateTime.Now;
            updateWord.PracticeCount++;

            DateTime dueDate = DateTime.Now;
            dueDate = dueDate.AddHours(addHours);
            updateWord.DueDate = dueDate;

            WordDatabaseHelper.Update(updateWord);

            SelectedIndex++;

            GoneNext?.Invoke(this, SelectedWord);
        }

        public void NextWordHard()
        {
            int p = SelectedWord.PracticeCount; // Practice count for the function addHours
            double addHours = (1 * p * p) + (5 * (p + 1));

            WordModel updateWord = SelectedWord;
            updateWord.UpdatedDate = DateTime.Now;
            updateWord.PracticeCount++;

            DateTime dueDate = DateTime.Now;
            dueDate = dueDate.AddHours(addHours);
            updateWord.DueDate = dueDate;

            WordDatabaseHelper.Update(updateWord);

            SelectedIndex++;

            GoneNext?.Invoke(this, SelectedWord);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public delegate void NextHandler(object sender, WordModel word);
        public event NextHandler GoneNext;
    }
}
