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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EnglishAimlessly2.UserControls
{
    /// <summary>
    /// Interaction logic for GroupItemControl.xaml
    /// </summary>
    public partial class GroupItemControl : UserControl
    {
        public GroupModel Group
        {
            get { return (GroupModel)GetValue(GroupProperty); }
            set { SetValue(GroupProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty GroupProperty =
            DependencyProperty.Register("Group", typeof(GroupModel), typeof(GroupItemControl), new PropertyMetadata(new GroupModel() { Name = "Name", Description = "This is a description"}, onChange));

        private static void onChange(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            GroupItemControl gic = d as GroupItemControl;
            if (gic != null)
            {
                gic.txtName.Text = (e.NewValue as GroupModel).Name;
                gic.txtDesc.Text = (e.NewValue as GroupModel).Description;
            }
        }

        public GroupItemControl()
        {
            InitializeComponent();
        }
    }
}
