﻿using EnglishAimlessly2.Model;
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
        public NextWordPracticeCommand NextWordPracticeCmd { get; set; }
        public PracticeVM()
        {
            if(!DesignerProperties.GetIsInDesignMode(new System.Windows.DependencyObject()))
            {
                WordDatabaseHelper = new WordTableHelper(DatabaseHelper.DATABASE_PATH);
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

        public void NextWord()
        {
            // beta code and should be changed later and be optimized
            WordModel updateWord = SelectedWord;
            updateWord.UpdatedDate = DateTime.Now;
            updateWord.PracticeCount++;
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