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
    /// Interaction logic for EditWordView.xaml
    /// </summary>
    public partial class EditWordView : Window
    {
        private ManagerVM ManagerViewModel { get; set; }
        private ManagerVM SenderMVM { get; set; }

        public EditWordView(ManagerVM senderMVM)
        {
            InitializeComponent();

            Owner = Application.Current.MainWindow;
            SenderMVM = senderMVM;
            ManagerViewModel = Resources["mvm"] as ManagerVM;

            ManagerViewModel.SelectedWordForFunctioning = SenderMVM.SelectedWordForFunctioning;

            ManagerViewModel.WordName = ManagerViewModel.SelectedWordForFunctioning.Name;
            ManagerViewModel.WordType = ManagerViewModel.SelectedWordForFunctioning.WordType;
            ManagerViewModel.Equivalent = ManagerViewModel.SelectedWordForFunctioning.Equivalent;
            ManagerViewModel.Description = ManagerViewModel.SelectedWordForFunctioning.Description;

            ManagerViewModel.Edited += ManagerViewModel_Edited;
        }

        private void ManagerViewModel_Edited(object sender, WordModel newWord)
        {
            SenderMVM.Reload();
            SenderMVM.SelectedWord = newWord;
            Close();
        }
    }
}