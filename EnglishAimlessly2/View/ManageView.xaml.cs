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
    /// Interaction logic for ManageView.xaml
    /// </summary>
    public partial class ManageView : Window
    {
        UserModel LoggedUser { get; set; }
        GroupModel SelectedGroup { get; set; }
        ManagerVM ManagerViewModel { get; set; }

        public ManageView(UserModel loggedUser, GroupModel selectedGroup)
        {
            InitializeComponent();
            Owner = Application.Current.MainWindow;
            LoggedUser = loggedUser;
            SelectedGroup = selectedGroup;
            ManagerViewModel = Resources["mvm"] as ManagerVM;
            ManagerViewModel.SelectedGroup = SelectedGroup;
            ManagerViewModel.LoggedUser = LoggedUser;

            borderDetails.Visibility = Visibility.Hidden;

            ManagerViewModel.SelectionWordChanged += ManagerViewModel_SelectionWordChanged;
        }

        private void ManagerViewModel_SelectionWordChanged(object sender)
        {
            if (ManagerViewModel.SelectedWord == null || ManagerViewModel.SelectedWord.Id <= 0)
            {
                borderDetails.Visibility = Visibility.Hidden;
                return;
            }
            borderDetails.Visibility = Visibility.Visible;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void txtWordName_TextChanged(object sender, TextChangedEventArgs e)
        {
            lstView.ItemsSource = ManagerViewModel.WordList.ToList().Where(x => x.Name.ToLower().Contains(txtWordName.Text.ToLower()));
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if(ManagerViewModel.SelectedWord != null)
            {
                Hide();
                AddWordView awv = new AddWordView(ManagerViewModel);
                awv.ShowDialog();
                ShowDialog();
            }
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            if (ManagerViewModel.SelectedWord != null)
            {
                Hide();
                ManagerViewModel.SelectedWordForFunctioning = ManagerViewModel.SelectedWord;
                EditWordView ewv = new EditWordView(ManagerViewModel);
                ewv.ShowDialog();
                ShowDialog();
            }
        }
    }
}
