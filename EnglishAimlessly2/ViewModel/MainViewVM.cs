using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnglishAimlessly2.Model;
using EnglishAimlessly2.ViewModel.Base;
using EnglishAimlessly2.ViewModel.Commands.MainWindow;

namespace EnglishAimlessly2.ViewModel
{
    public class MainViewVM : BaseVM
    {
        private BaseVM _selectedViewModel;
        public UserModel LoggedUser { get; set; }
        public GroupModel SelectedGroup { get; set; }
        public WordModel SelectedWord { get; set; }
        public BaseVM SelectedViewModel
        {
            get {  return _selectedViewModel; }
            set
            {
                _selectedViewModel = value;
                onPropertyChanged(nameof(SelectedViewModel));
            }
        }

        public UpdateViewCommand UpdateViewCmd { get; set; }

        public MainViewVM()
        {
            UpdateViewCmd = new UpdateViewCommand(this);
            ChangeViewByName("Login");
        }

        public void ChangeViewByName(string name)
        {
            if (name == "MainMenu")
            {
                MainMenuVM.MainViewModel = this;
                SelectedViewModel = new MainMenuVM();
            }
            else if (name == "Login")
            {
                UserCredentialVM.MainViewModel = this;
                SelectedViewModel = new UserCredentialVM() { };
            }
            else if (name == "NormalPractice")
            {
                PracticeVM.MainViewModel = this;
                SelectedViewModel = new PracticeVM();
            }
            else if (name == "MasterPractice")
            {
                MasterPracticeVM.MainViewModel = this;
                SelectedViewModel = new MasterPracticeVM();
            }
            else if (name == "MasterWords")
            {
                MasteredWordsVM.MainViewModel = this;   
                SelectedViewModel = new MasteredWordsVM();
            }
            else if (name == "ManageWords")
            {
                ManagerVM.MainViewModel = this;
                SelectedViewModel = new ManagerVM();

            }
            else if (name == "Settings")
            {
                GroupSettingsVM.MainViewModel = this;
                SelectedViewModel = new GroupSettingsVM();
            }
        }
    }
}
