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
        UserModel loggedUser;
        MainMenuVM mmvm;
        public MainMenuView(UserModel user)
        {
            InitializeComponent();
            loggedUser = user;
            mmvm = Resources["mmvm"] as MainMenuVM;
            mmvm.LoggedUser = loggedUser;

            Owner = Application.Current.MainWindow;

            Closed += MainMenuView_Closed;
        }

        private void MainMenuView_Closed(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void txtGroupName_TextChanged(object sender, TextChangedEventArgs e)
        {
            lstView.ItemsSource = mmvm.Groups.ToList().Where(x => x.Name.ToLower().Contains(txtGroupName.Text.ToLower()));
        }
    }
}
