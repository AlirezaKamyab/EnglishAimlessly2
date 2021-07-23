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
    public class RemoveGroupCommand : ICommand
    {
        private MainMenuVM mmvm { get; set; }
        public RemoveGroupCommand(MainMenuVM mainMenuVm)
        {
            mmvm = mainMenuVm;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value;}
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            if (mmvm.SelectedGroup == null) return false;
            return true;
        }

        public void Execute(object parameter)
        {
            DialogResultModel dialogResult = new DialogResultModel();
            ConfirmationView confirmation = new ConfirmationView("Remove confirmation", string.Format("Are you sure you want to remove the group \"{0}\"?", mmvm.SelectedGroup.Name), dialogResult);
            confirmation.ShowDialog();

            if (dialogResult.DialogResult == Result.Yes) mmvm.RemoveGroup();
        }
    }
}
