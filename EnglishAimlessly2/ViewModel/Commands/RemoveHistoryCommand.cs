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
    public class RemoveHistoryCommand : ICommand
    {
        private HistoryVM _hvm;
        public RemoveHistoryCommand(HistoryVM historyViewModel)
        {
            _hvm = historyViewModel;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            int value = Convert.ToInt32(parameter as string);
            if (value == 0)
            {
                return _hvm.SelectedHistory != null;
            }
            else if (value == 1)
            {
                return _hvm.SelectedGroupHistory != null;
            }
            else return false;
        }

        public void Execute(object parameter)
        {
            int value = Convert.ToInt32(parameter as string);

            DialogResultModel drm = new DialogResultModel();
            ConfirmationView cv = new ConfirmationView("Remove History Confirmation", "Are you sure you want to remove this history permanently?", drm);
            if (value == 0)
            {
                cv.ShowDialog();
                if (drm.DialogResult == Result.Yes) _hvm.DeleteHistory();
            }
            else if (value == 1)
            {
                cv.ShowDialog();
                if (drm.DialogResult == Result.Yes) _hvm.DeleteGroupHistory();
            }
        }
    }
}
