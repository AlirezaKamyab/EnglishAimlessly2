﻿using EnglishAimlessly2.Model;
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
    /// Interaction logic for WordItemControl.xaml
    /// </summary>
    public partial class WordItemControl : UserControl
    {
        public WordModel Word
        {
            get { return (WordModel)GetValue(WordProperty); }
            set { SetValue(WordProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Word.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty WordProperty =
            DependencyProperty.Register("Word", typeof(WordModel), typeof(WordItemControl), new PropertyMetadata(new WordModel(), OnWordChange));

        private static void OnWordChange(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            WordItemControl wic = d as WordItemControl;
            
            if(wic != null)
            {
                WordModel newWord = e.NewValue as WordModel;
                wic.txtWord.Text = newWord.Name;
                wic.txtType.Text = "(" + newWord.WordType + ")";
                wic.txtDesc.Text = newWord.Description;
            }
        }

        public WordItemControl()
        {
            InitializeComponent();
        }
    }
}
