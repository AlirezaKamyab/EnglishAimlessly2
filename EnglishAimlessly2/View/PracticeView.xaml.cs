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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace EnglishAimlessly2.View
{
    /// <summary>
    /// Interaction logic for PracticeView.xaml
    /// </summary>
    public partial class PracticeView : Window
    {
        private PracticeVM PracticeViewModel { get; set; }
        public PracticeView(GroupModel selectedGroup)
        {
            InitializeComponent();
            Owner = Application.Current.MainWindow;

            PracticeVM pvm = FindResource("pvm") as PracticeVM;
            PracticeViewModel = pvm;
            pvm.SelectedGroup = selectedGroup;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnShow_Click(object sender, RoutedEventArgs e)
        {
            Storyboard showDetailsAnimation = FindResource("ShowDetails") as Storyboard;
            showDetailsAnimation.Begin();
        }

        private void btnNextEasy_Click(object sender, RoutedEventArgs e)
        {
            pnlButtons.IsEnabled = false;
            Storyboard nextWordAnimation = FindResource("NextWord") as Storyboard;
            nextWordAnimation.Completed += NextWordAnimation_Completed;
            nextWordAnimation.Begin();

            Storyboard hideDetailsAnimation = FindResource("HideDetails") as Storyboard;
            hideDetailsAnimation.Begin();
        }

        private void NextWordAnimation_Completed(object sender, EventArgs e)
        {
            pnlButtons.IsEnabled = true;
        }
    }
}
