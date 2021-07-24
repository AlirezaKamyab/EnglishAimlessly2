using EnglishAimlessly2.Model;
using EnglishAimlessly2.ViewModel;
using EnglishAimlessly2.ViewModel.Helper;
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

            DateTime today = DateTime.Now;
            DateTime dteTime = DateTime.Now;
            dteTime = dteTime.AddHours(1);
            dteTime = dteTime.AddMinutes(23);
            dteTime = dteTime.AddSeconds(12);
            dteTime = dteTime.AddDays(-2);
            TimeModel time = DateTimeHelper.GetTimeModel(today, dteTime);
            txt.Text = string.Format("Seconds: {0}\n" + "Minutes: {1}\n" + "Hours: {2}\n" + "Days: {3}\n" + "Date Today: {4}\n" + "Date Target: {5}",time.Seconds.ToString(), time.Minutes.ToString(), time.Hours.ToString(), time.Days.ToString(), DateTime.Now.ToLongDateString(), dteTime.ToLongDateString());

            SortedList<int, string> a = new SortedList<int, string>()
            {
                {1,  "Alireza"}, {2, "Someoneelse"}, {3, "hello, world"}
            };

            foreach (string item in a.Values)
            {
                txt2.Text += string.Format("{0}\n", item);
            }
        }
    }
}
