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
    public class ResetWordCommand : ICommand
    {
        private ManagerVM ManagerViewModel { get; set; }

        public ResetWordCommand(ManagerVM vm)
        {
            ManagerViewModel = vm;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            ManagerViewModel.SelectedWordForFunctioning = ManagerViewModel.SelectedWord;
            if (ManagerViewModel.SelectedWordForFunctioning == null) return;
            DialogResultModel drm = new DialogResultModel();
            ConfirmationView confirmation = new ConfirmationView("Reset confirmation", string.Format("Are you sure to reset the word \"{0}\" from database?", ManagerViewModel.SelectedWordForFunctioning.Name), drm);
            confirmation.ShowDialog();

            if (drm.DialogResult == Result.Yes) ManagerViewModel.ResetWord();
        }
    }
}
