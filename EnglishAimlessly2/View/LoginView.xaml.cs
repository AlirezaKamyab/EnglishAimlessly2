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
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : Window
    {
        UserCredentialVM uvm;
        public LoginView()
        {
            InitializeComponent();
            uvm = Resources["uvm"] as UserCredentialVM;

            Loaded += LoginView_Loaded;
            this.Activated += LoginView_Activated;
        }

        private void LoginView_Activated(object sender, EventArgs e)
        {
            checkedStayLoggedIn.IsChecked = Properties.Settings.Default.StayLoggedin;
        }

        private void LoginView_Loaded(object sender, RoutedEventArgs e)
        {
            if (Properties.Settings.Default.StayLoggedin)
            {
                UserModel logged = uvm.UserTableHelper.SearchById(Properties.Settings.Default.UserId);
                if (logged != null && logged.Id > 0)
                {
                    Hide();
                    MainMenuView mmv = new MainMenuView(logged, this);
                    mmv.ShowDialog();
                }
            }
        }

        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            txtPass.Text = (sender as PasswordBox).Password;
        }

        private void btnCreateAccountPage_Click(object sender, RoutedEventArgs e)
        {
            RegisterView registerView = new RegisterView();
            Hide();
            registerView.ShowDialog();
            uvm.Reload();
            ShowDialog();
        }

        private void UserCredentialVM_Loggedin(object sender, Model.UserModel user)
        {
            Hide();
            Properties.Settings.Default.UserId = user.Id;
            Properties.Settings.Default.Save();
            MainMenuView mmv = new MainMenuView(user, this);
            mmv.ShowDialog();
        }

        private void checkedStayLoggedIn_Click(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.StayLoggedin = (bool) checkedStayLoggedIn.IsChecked;
            Properties.Settings.Default.Save();
        }
    }
}
