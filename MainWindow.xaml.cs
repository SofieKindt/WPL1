﻿using System;
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

namespace WPL1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnTekst_Click(object sender, RoutedEventArgs e)
        {
            lblTekst.Content = "Hello World";
        }
        int teller = 0;
        private void bntTeller_Click(object sender, RoutedEventArgs e)
        {
            
            lblTeller.Content = teller;
            teller++;

        }
    }
}
