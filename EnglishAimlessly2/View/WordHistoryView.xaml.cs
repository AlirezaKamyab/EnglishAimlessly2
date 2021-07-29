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
    /// Interaction logic for WordHistoryView.xaml
    /// </summary>
    public partial class WordHistoryView : Window
    {
        private HistoryVM hvm { get; set; }
        public WordHistoryView(int wordId)
        {
            InitializeComponent();

            Owner = Application.Current.MainWindow;
            hvm = FindResource("hvm") as HistoryVM;
            hvm.WordId = wordId;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
