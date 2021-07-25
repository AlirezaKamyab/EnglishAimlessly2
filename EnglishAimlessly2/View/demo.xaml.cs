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
        }

        private void txtBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string[] line = txtBox.Text.Split('\n');
            txt.Text = "";

            for (int l = 0; l < line.Length; l++)
            {
                string[] word = line[l].Split(':');
                if (word.Length != 3) continue;
                WordModel model = new WordModel();
                model.Name = word[0].Trim();
                model.Equivalent = word[1].Trim();
                model.Description = word[2].Trim();
                txt.Text += string.Format("Name: {0}\t Equivalent: {1}\tDescription: {2}\n", model.Name, model.Equivalent, model.Description);
            }
        }
    }
}
