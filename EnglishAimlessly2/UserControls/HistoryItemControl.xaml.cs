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
    /// Interaction logic for HistoryItemControl.xaml
    /// </summary>
    public partial class HistoryItemControl : UserControl
    {
        SolidColorBrush dodgerBlue = new SolidColorBrush(Colors.DodgerBlue);
        SolidColorBrush orange = new SolidColorBrush(Colors.Orange);
        SolidColorBrush red = new SolidColorBrush(Colors.Red);
        SolidColorBrush white = new SolidColorBrush(Colors.White);
        SolidColorBrush black = new SolidColorBrush(Colors.Black);
        public HistoryModel History
        {
            get { return (HistoryModel)GetValue(HistoryProperty); }
            set { SetValue(HistoryProperty, value); }
        }

        // Using a DependencyProperty as the backing store for History.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty HistoryProperty =
            DependencyProperty.Register("History", typeof(HistoryModel), typeof(HistoryItemControl), new PropertyMetadata(new HistoryModel(), changed));

        private static void changed(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            HistoryItemControl itemControl = d as HistoryItemControl;
            if(itemControl != null)
            {
                HistoryModel history = e.NewValue as HistoryModel;
                itemControl.txtWord.Text = history.Word;
                itemControl.txtType.Text = history.WordType;
                itemControl.txtDate.Text = history.PracticedDate.ToShortDateString();
                itemControl.txtTime.Text = " " + history.PracticedDate.ToShortTimeString();
                itemControl.txtExample.Text = " " + history.Example;

                if (history.DifficultyLevel == 1) itemControl.border.BorderBrush = itemControl.dodgerBlue;
                else if (history.DifficultyLevel == 2) itemControl.border.BorderBrush = itemControl.orange;
                else if (history.DifficultyLevel == 3) itemControl.border.BorderBrush = itemControl.red;
                else if (history.DifficultyLevel == 4) itemControl.border.BorderBrush = itemControl.black;
                else itemControl.border.BorderBrush = itemControl.black;
            }
        }

        public HistoryItemControl()
        {
            InitializeComponent();
        }
    }
}
