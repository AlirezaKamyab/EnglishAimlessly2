using EnglishAimlessly2.Model;
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
    /// Interaction logic for ConfirmationView.xaml
    /// </summary>
    public partial class ConfirmationView : Window
    {
        DialogResultModel dialogResult;
        public ConfirmationView(string title, string message, DialogResultModel result)
        {
            InitializeComponent();
            Owner = Application.Current.MainWindow;
            lblTitle.Text = title;
            lblMessage.Text = message;
            dialogResult = result;
        }

        private void btnYes_Click(object sender, RoutedEventArgs e)
        {
            dialogResult.DialogResult = Result.Yes;
            Close();
        }

        private void btnNo_Click(object sender, RoutedEventArgs e)
        {
            dialogResult.DialogResult = Result.No;
            Close();
        }
    }
}
