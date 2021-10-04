using EnglishAimlessly2.Model;
using EnglishAimlessly2.UserControls;
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
    /// Interaction logic for MasteredWordsView.xaml
    /// </summary>
    public partial class MasteredWordsView : Window
    {
        private MasteredWordsVM mwvm;
        public MasteredWordsView(GroupModel group)
        {
            InitializeComponent();
            Owner = Application.Current.MainWindow;
            mwvm = FindResource("mwvm") as MasteredWordsVM;
            mwvm.Group = group;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
    }
}
