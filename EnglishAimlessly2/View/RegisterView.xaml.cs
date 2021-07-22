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
    /// Interaction logic for RegisterView.xaml
    /// </summary>
    public partial class RegisterView : Window
    {
        public RegisterView()
        {
            InitializeComponent();
            Owner = Application.Current.MainWindow;
        }

        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            txtPass.Text = (sender as PasswordBox).Password;
        }

        private void btnBackToLogin_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void UserCredentialVM_Registered(object sender, Model.UserModel user)
        {
            Close();
        }
    }
}
