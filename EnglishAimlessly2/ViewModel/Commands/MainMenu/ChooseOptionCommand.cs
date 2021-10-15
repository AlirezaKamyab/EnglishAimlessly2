using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EnglishAimlessly2.ViewModel.Commands.MainMenu
{
    public class ChooseOptionCommand : ICommand
    {
        private MainMenuVM mmvm;
        public ChooseOptionCommand(MainMenuVM viewModel)
        {
            mmvm = viewModel;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            if (parameter.ToString() == "MasterPractice" && mmvm.MasterWordsCount <= 0) return false;
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter.ToString() == "Login") MainMenuVM.MainViewModel.ChangeViewByName("Login");

            if (mmvm.SelectedGroup == null) return;
            MainMenuVM.MainViewModel.SelectedGroup = mmvm.SelectedGroup;

            if (parameter.ToString() == "NormalPractice") MainMenuVM.MainViewModel.ChangeViewByName("NormalPractice");
            else if (parameter.ToString() == "MasterPractice") MainMenuVM.MainViewModel.ChangeViewByName("MasterPractice");
            else if (parameter.ToString() == "MasterWords") MainMenuVM.MainViewModel.ChangeViewByName("MasterWords");
            else if (parameter.ToString() == "ManageWords") MainMenuVM.MainViewModel.ChangeViewByName("ManageWords");
            else if (parameter.ToString() == "Settings") MainMenuVM.MainViewModel.ChangeViewByName("Settings");
        }
    }
}
