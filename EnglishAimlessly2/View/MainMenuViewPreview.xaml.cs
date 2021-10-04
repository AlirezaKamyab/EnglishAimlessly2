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
    /// Interaction logic for MainMenuViewPreview.xaml
    /// </summary>
    public partial class MainMenuViewPreview : Window
    {
        public MainMenuViewPreview()
        {
            InitializeComponent();
            List<GroupModel> groups = new List<GroupModel>();
            for (int i = 0; i < 10; i++)
            {
                GroupModel g = new GroupModel();
                g.Name = "Hello";
                g.Description = "sdfg";
                groups.Add(g);
            }
            test.ItemsSource = groups;
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
    }
}
