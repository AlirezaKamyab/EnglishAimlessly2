using EnglishAimlessly2.Model;
using EnglishAimlessly2.UserControls;
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
    public class MasteredWordsVM : INotifyPropertyChanged
    {
        private GroupModel _group;
        private WordModel _selectedWord;
        private System.Windows.Visibility _panelVisibility = System.Windows.Visibility.Collapsed;

        public WordModel SelectedWord
        {
            get {  return _selectedWord; }
            set 
            {  
                _selectedWord = value;
                if (SelectedWord != null) PanelVisibility = System.Windows.Visibility.Visible;
                else PanelVisibility = System.Windows.Visibility.Collapsed;
                onPropertyChanged(nameof(SelectedWord));
            }
        }
        public GroupModel Group
        {
            get
            {
                return _group;
            }
            set
            {
                if (value != null)
                {
                    _group = value;
                    Reload();
                    onPropertyChanged(nameof(Group));
                }
            }
        }
        public System.Windows.Visibility PanelVisibility
        {
            get {  return _panelVisibility; }
            set
            {
                _panelVisibility = value;
                onPropertyChanged(nameof(PanelVisibility));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<WordModel> MasterWords { get; set; }
        
        // Commands
        public CheckPointCommand CheckPointCmd { get; set; }
        public MasteredWordsVM ()
        {
            MasterWords = new ObservableCollection<WordModel>();
            if(DesignerProperties.GetIsInDesignMode(new System.Windows.DependencyObject()) == false)
            {
                
            }

            // Commands
            CheckPointCmd = new CheckPointCommand(this);
        }

        public void Reload()
        {
            WordTableHelper helper = new WordTableHelper(DatabaseHelper.DATABASE_PATH);
            MasterWords.Clear();
            foreach(WordModel item in helper.GetListByScore(Group.Id, 1000))
            {
                MasterWords.Add(item);
            }
        }

        private void onPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public void setCheckPoint()
        {
            if (SelectedWord == null) return;
            WordTableHelper wordHelper = new WordTableHelper(DatabaseHelper.DATABASE_PATH);
            WordModel newWord = SelectedWord;
            newWord.CheckPointScore = newWord.Score;
            newWord.DueDate = DateTime.Now;
            wordHelper.Update(newWord);
        }

    }
}
