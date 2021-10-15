using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace EnglishAimlessly2.ViewModel.Commands.Practice
{
    public class ShowAnswerCommand : ICommand
    {
        PracticeVM vm;
        public ShowAnswerCommand(PracticeVM viewModel)
        {
            vm = viewModel;
        }
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            vm.AnswerVisibility = Visibility.Visible;
            vm.ShowButtonVisibility = Visibility.Collapsed;
        }
    }
}
