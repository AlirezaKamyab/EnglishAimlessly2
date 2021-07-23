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
    public class GroupSettingsVM : INotifyPropertyChanged
    {
        private string _groupName;
        private string _description;
        private GroupModel _selectedGroup;
        private GroupTableHelper _groupHelper;

        public event PropertyChangedEventHandler PropertyChanged;

        public string GroupName
        {
            get
            {
                return _groupName;
            }
            set
            {
                _groupName = value;
                OnPropertyChanged(nameof(GroupName));
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

        public GroupModel SelectedGroup
        {
            get
            {
                return _selectedGroup;
            }
            set
            {
                _selectedGroup = value;
                if (SelectedGroup != null) Load();
                OnPropertyChanged(nameof(SelectedGroup));
            }
        }

        public UpdateGroupCommand UpdateGroupCmd { get; set; }

        public GroupSettingsVM()
        {
            if (!DesignerProperties.GetIsInDesignMode(new System.Windows.DependencyObject()))
            {
                _groupHelper = new GroupTableHelper(DatabaseHelper.DATABASE_PATH);
            }

            // Commands
            UpdateGroupCmd = new UpdateGroupCommand(this);
        }
        private void Load()
        {
            _groupHelper.Reload();
            _selectedGroup = _groupHelper.SearchById(SelectedGroup.Id);
            GroupName = SelectedGroup.Name;
            Description = SelectedGroup.Description;
        }

        public void Update()
        {
            if (SelectedGroup == null) return;

            GroupModel groupModel = new GroupModel();
            groupModel.Id = SelectedGroup.Id;
            groupModel.UserId = SelectedGroup.UserId;
            groupModel.Name = GroupName;
            groupModel.Description = Description;
            groupModel.CreationDate = SelectedGroup.CreationDate;
            groupModel.UpdatedDate = DateTime.Now;

            _groupHelper.Update(groupModel);
            _groupHelper.Reload();
            SelectedGroup = _groupHelper.SearchById(groupModel.Id);
            Updated?.Invoke(this, groupModel);
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public delegate void UpdateHandler(object sender, GroupModel newGroup);
        public event UpdateHandler Updated;
    }
}
