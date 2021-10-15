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
    /// Interaction logic for AddTogetherView.xaml
    /// </summary>
    public partial class AddTogetherView : Window
    {
        private ManagerVM manager;
        private AddTogetherVM atvm;
        public AddTogetherView(ManagerVM vm)
        {
            InitializeComponent();
            Owner = Application.Current.MainWindow;

            manager = vm;
            atvm = FindResource("atvm") as AddTogetherVM;
            atvm.SelectedGroup = manager.SelectedGroup;
        }

        private void Closed_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
