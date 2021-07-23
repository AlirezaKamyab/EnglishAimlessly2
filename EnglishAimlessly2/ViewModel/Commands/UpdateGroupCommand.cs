using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EnglishAimlessly2.ViewModel.Commands
{
    public class UpdateGroupCommand : ICommand
    {
        private GroupSettingsVM GroupVM { get; set; }
        public UpdateGroupCommand(GroupSettingsVM gsvm)
        {
            GroupVM = gsvm;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            if (GroupVM.SelectedGroup == null) return false;
            if (GroupVM.SelectedGroup.Name == GroupVM.GroupName && GroupVM.SelectedGroup.Description == GroupVM.Description)
            {
                return false;
            }
            else return true;
        }

        public void Execute(object parameter)
        {
            GroupVM.Update();
        }
    }
}
