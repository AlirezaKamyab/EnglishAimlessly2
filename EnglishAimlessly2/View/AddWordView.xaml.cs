﻿using EnglishAimlessly2.Model;
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
    /// Interaction logic for AddWordView.xaml
    /// </summary>
    public partial class AddWordView : Window
    {
        private ManagerVM ManagerViewModel { get; set; }
        private ManagerVM SenderVM { get; set; }
        public AddWordView(ManagerVM senderVM)
        {
            InitializeComponent();

            Owner = Application.Current.MainWindow;
            SenderVM = senderVM;
            ManagerViewModel = Resources["mvm"] as ManagerVM;

            ManagerViewModel.SelectedGroup = SenderVM.SelectedGroup;
            ManagerViewModel.LoggedUser = SenderVM.LoggedUser;

            ManagerViewModel.Added += ManagerViewModel_Added;
        }

        private void ManagerViewModel_Added(object sender, WordModel addedWord)
        {
            SenderVM.Reload();
            SenderVM.SelectedWord = addedWord;
            Close();
        }
    }
}
