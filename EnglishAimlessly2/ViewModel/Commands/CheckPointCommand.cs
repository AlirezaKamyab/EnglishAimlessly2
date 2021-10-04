using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EnglishAimlessly2.ViewModel.Commands
{
    public class CheckPointCommand : ICommand
    {
        private MasteredWordsVM masteredWordsVM;
        public CheckPointCommand(MasteredWordsVM mwvm)
        {
            masteredWordsVM = mwvm;
        }
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value;}
            remove { CommandManager.RequerySuggested -= value;}
        }

        public bool CanExecute(object parameter)
        {
            if (masteredWordsVM.SelectedWord == null) return false;
            if (masteredWordsVM.SelectedWord.Score == masteredWordsVM.SelectedWord.CheckPointScore) return false;
            return true;
        }

        public void Execute(object parameter)
        {
            masteredWordsVM.setCheckPoint();
        }
    }
}
