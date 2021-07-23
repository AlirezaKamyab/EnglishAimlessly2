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
    /// Interaction logic for GroupSettingsView.xaml
    /// </summary>
    public partial class GroupSettingsView : Window
    {
        private GroupSettingsVM gsvm;
        public GroupSettingsView(GroupModel SelectedGroup)
        {
            InitializeComponent();
            Owner = Application.Current.MainWindow;

            gsvm = Resources["gsvm"] as GroupSettingsVM;
            gsvm.SelectedGroup = SelectedGroup;
        }
    }
}
