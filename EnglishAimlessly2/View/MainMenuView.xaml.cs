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
using Notification.Wpf;

namespace EnglishAimlessly2.View
{
    /// <summary>
    /// Interaction logic for MainMenuView.xaml
    /// </summary>
    public partial class MainMenuView : Window
    {
        bool baseWindow = true;
        UserModel loggedUser;
        MainMenuVM mmvm;
        LoginView loginView;

        private readonly System.Windows.Forms.NotifyIcon notify;
        public MainMenuView(UserModel user, LoginView login)
        {
            InitializeComponent();
            loggedUser = user;
            mmvm = Resources["mmvm"] as MainMenuVM;
            mmvm.LoggedUser = loggedUser;
            loginView = login;

            notify = new System.Windows.Forms.NotifyIcon();
            notify.Icon = Properties.Resources.EAIcon;
            notify.Visible = true;
            notify.Text = "English Aimlessly";
            notify.Click += Notify_Click;

            Owner = Application.Current.MainWindow;
            borderMain.Visibility = Visibility.Hidden;

            Closing += MainMenuView_Closing;
            mmvm.OnTime += Mmvm_OnTime;
        }

        private void Notify_Click(object sender, EventArgs e)
        {
            if (Visibility == Visibility.Hidden)
            {
                mmvm.ForceUpdateInformationForGroup();
                ShowDialog();
                Activate();
            }
        }

        private void Mmvm_OnTime(object sender, GroupModel readyGroup)
        {
            NotificationContent content = new NotificationContent();
            content.Title = "Practice is ready";
            content.Message = string.Format("{0} is available for practice", readyGroup.Name);
            content.RightButtonContent = "Show";
            content.RightButtonAction = Show;
            content.Type = NotificationType.Success;
            NotificationManager manager = new NotificationManager();
            manager.Show(content);
            mmvm.ForceUpdateInformationForGroup();
            mmvm.SelectedGroup = readyGroup;
        }

        private void MainMenuView_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            notify.Dispose();
            if (baseWindow) Application.Current.Shutdown();
        }

        private void txtGroupName_TextChanged(object sender, TextChangedEventArgs e)
        {
            lstView.ItemsSource = mmvm.Groups.ToList().Where(x => x.Name.ToLower().Contains(txtGroupName.Text.ToLower()));
        }

        private void lstView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (mmvm.SelectedGroup == null) borderMain.Visibility = Visibility.Hidden;
            else if(mmvm.SelectedGroup.Id < 0) borderMain.Visibility = Visibility.Hidden;
            else borderMain.Visibility = Visibility.Visible;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            baseWindow = false;
            Properties.Settings.Default.StayLoggedin = false;
            Properties.Settings.Default.Save();
            loginView.Show();
            Close();
        }

        private void btnManager_Click(object sender, RoutedEventArgs e)
        {
            if(mmvm.SelectedGroup != null)
            {
                mmvm.StopTimer();
                Hide();
                ManageView manageView = new ManageView(loggedUser, mmvm.SelectedGroup);
                manageView.ShowDialog();
                mmvm.ForceUpdateInformationForGroup();
                mmvm.StartTimer();
                ShowDialog();
            }
        }

        private void btnGroupSettings_Click(object sender, RoutedEventArgs e)
        {
            if(mmvm.SelectedGroup != null)
            {
                mmvm.StopTimer();
                Hide();
                GroupSettingsView view = new GroupSettingsView(mmvm.SelectedGroup);
                view.ShowDialog();
                mmvm.ForceUpdateInformationForGroup();
                mmvm.StartTimer();
                ShowDialog();
            }
        }

        private void btnPractice_Click(object sender, RoutedEventArgs e)
        {
            if(mmvm.SelectedGroup != null)
            {
                mmvm.StopTimer();
                Hide();
                PracticeView view = new PracticeView(mmvm.SelectedGroup);
                view.ShowDialog();
                mmvm.ForceUpdateInformationForGroup();
                mmvm.StartTimer();
                ShowDialog();
            }
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            Hide();
        }
    }
}
