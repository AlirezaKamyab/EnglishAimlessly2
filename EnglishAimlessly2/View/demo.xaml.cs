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
        public demo()
        {
            InitializeComponent();
            Loaded += Demo_Loaded;
        }

        private void Demo_Loaded(object sender, RoutedEventArgs e)
        {
            DialogResultModel dialog = new DialogResultModel();
            ConfirmationView confirmation = new ConfirmationView("asdf", "dsfjh", dialog);
            confirmation.ShowDialog();

            if (dialog.DialogResult == Result.Yes) { txt.Text = "Yes"; }
            else txt.Text = "No";
        }
    }
}
