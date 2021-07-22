using EnglishAimlessly2.Model;
using EnglishAimlessly2.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace EnglishAimlessly2.View
{
    /// <summary>
    /// Interaction logic for ManageView.xaml
    /// </summary>
    public partial class ManageView : Window
    {
        MainMenuView MainMenu { get; set; }
        UserModel LoggedUser { get; set; }
        GroupModel SelectedGroup { get; set; }
        ManagerVM ManagerViewModel { get; set; }

        public ManageView(UserModel loggedUser, GroupModel selectedGroup, MainMenuView mmv)
        {
            InitializeComponent();
            Owner = Application.Current.MainWindow;
            MainMenu = mmv;
            LoggedUser = loggedUser;
            SelectedGroup = selectedGroup;
            ManagerViewModel = Resources["mvm"] as ManagerVM;
            ManagerViewModel.SelectedGroup = SelectedGroup;
            ManagerViewModel.LoggedUser = LoggedUser;

            borderDetails.Visibility = Visibility.Hidden;

            Closing += ManageView_Closing;
        }

        private void ManageView_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MainMenu.Show();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void txtWordName_TextChanged(object sender, TextChangedEventArgs e)
        {
            lstView.ItemsSource = ManagerViewModel.WordList.ToList().Where(x => x.Name.ToLower().Contains(txtWordName.Name));
        }

        private void lstView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(lstView.SelectedValue == null)
            {
                borderDetails.Visibility = Visibility.Hidden;
                return;
            }
            borderDetails.Visibility = Visibility.Visible;
        }
    }
}
