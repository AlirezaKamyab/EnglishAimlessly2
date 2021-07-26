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
    public class AddTogetherVM : INotifyPropertyChanged
    {
        private GroupModel _selectedGroup;
        private string _text;
        public string Text
        {
            get
            {
                return _text;
            }
            set
            {
                _text = value;
                Clasify();
                OnPropertyChanged(nameof(Text));
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
                if(value != null)
                {
                    _selectedGroup = value;
                    OnPropertyChanged(nameof(SelectedGroup));
                }
            }
        }

        public ObservableCollection<WordModel> Collection { get; set; }
        public WordTableHelper WordHelper { get; set; }
        public AddTogetherCommand AddTogetherCmd { get; set; }

        public AddTogetherVM()
        {
            Collection = new ObservableCollection<WordModel>();
            if(!DesignerProperties.GetIsInDesignMode(new System.Windows.DependencyObject()))
            {
                WordHelper = new WordTableHelper(DatabaseHelper.DATABASE_PATH);
            }

            // Commands
            AddTogetherCmd = new AddTogetherCommand(this);
        }

        private void Clasify()
        {
            if (SelectedGroup == null) return;

            string[] line = Text.Split('\n');
            Collection.Clear();

            for (int l = line.Length - 1; l >= 0; l--)
            {
                string[] word = line[l].Split(':');
                if (!(word.Length >= 3 && word.Length <= 4)) continue;

                WordModel model = new WordModel();
                model.Name = word[0].Trim();
                model.Equivalent = word[1].Trim();

                string[] descriptions = word[2].Trim().Split('#');
                for(int i = 0; i < descriptions.Length; i++)
                {
                    model.Description += string.Format("{0}: {1}\n", i + 1, descriptions[i]);
                }

                model.PracticeCount = 0;
                model.CreationDate = DateTime.Now;
                model.UpdatedDate = DateTime.Now;
                model.DueDate = DateTime.Now;
                model.GroupId = SelectedGroup.Id;
                model.UserId = SelectedGroup.UserId;

                if (word.Length != 4) model.WordType = "";
                else model.WordType = word[3].Trim();

                Collection.Add(model);
            }
        }

        public void AddTogether()
        {
            for(int i = 0; i < Collection.Count; i++)
            {
                WordHelper.Insert(Collection[i]);
            }
            Text = "";

            Added?.Invoke(this);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public delegate void AddHandler(object sender);
        public event AddHandler Added;
    }
}
