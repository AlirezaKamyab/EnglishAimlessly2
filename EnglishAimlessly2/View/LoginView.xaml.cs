﻿using EnglishAimlessly2.ViewModel;
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
            MainMenuView mmv = new(user, this);
            mmv.ShowDialog();
        }
    }
}
