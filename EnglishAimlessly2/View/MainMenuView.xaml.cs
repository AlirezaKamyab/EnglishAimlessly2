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
    /// Interaction logic for MainMenuView.xaml
    /// </summary>
    public partial class MainMenuView : Window
    {
        bool baseWindow = true;
        UserModel loggedUser;
        LoginView loginView;
        MainMenuVM mmvm;
        public MainMenuView(UserModel user, LoginView login)
        {
            InitializeComponent();
            loggedUser = user;
            loginView = login;
            mmvm = Resources["mmvm"] as MainMenuVM;
            mmvm.LoggedUser = loggedUser;

            Owner = Application.Current.MainWindow;
            borderMain.Visibility = Visibility.Hidden;

            Closed += MainMenuView_Closed;
        }

        private void MainMenuView_Closed(object sender, EventArgs e)
        {
            if (baseWindow) Application.Current.Shutdown();
        }

        private void txtGroupName_TextChanged(object sender, TextChangedEventArgs e)
        {
            lstView.ItemsSource = mmvm.Groups.ToList().Where(x => x.Name.ToLower().Contains(txtGroupName.Text.ToLower()));
        }

        private void lstView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (mmvm.SelectedGroup == null) borderMain.Visibility = Visibility.Hidden;
            else if(mmvm.SelectedGroup.Id < 0) borderMain.Visibility = Visibility.Hidden;
            else borderMain.Visibility = Visibility.Visible;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            baseWindow = false;
            Close();
            loginView.Show();
        }
    }
}
