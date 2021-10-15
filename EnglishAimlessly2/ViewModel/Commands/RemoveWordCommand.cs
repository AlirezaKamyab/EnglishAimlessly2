using EnglishAimlessly2.Model;
using EnglishAimlessly2.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EnglishAimlessly2.ViewModel.Commands
{
    public class RemoveWordCommand : ICommand
    { 
        private ManagerVM managerViewModel { get; set; }
        public RemoveWordCommand(ManagerVM mvm)
        {
            managerViewModel = mvm;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            managerViewModel.SelectedWord = managerViewModel.SelectedWord;
            if (managerViewModel.SelectedWord == null) return;
            DialogResultModel drm = new DialogResultModel();
            ConfirmationView confirmation = new ConfirmationView("Remove confirmation", string.Format("Are you sure to remove the word \"{0}\" from database?", managerViewModel.SelectedWord.Name), drm);
            confirmation.ShowDialog();

            if (drm.DialogResult == Result.Yes)
            {
                managerViewModel.RemoveWord();
                managerViewModel.Reload();
            }
        }
    }
}
