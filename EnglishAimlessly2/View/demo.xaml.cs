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
    /// Interaction logic for demo.xaml
    /// </summary>
    public partial class demo : Window
    {
        UserModel loggedUser;
        public demo(UserModel user)
        {
            InitializeComponent();
            loggedUser = user;

            MainMenuVM mmvm = Resources["mmvm"] as MainMenuVM;
            mmvm.LoggedUser = loggedUser;
            Closing += Demo_Closing;
        }

        private void Demo_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
