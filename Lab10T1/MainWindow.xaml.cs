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

namespace Lab10T1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int a = 0;
        int b = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void nappi1_Click(object sender, RoutedEventArgs e)
        {
            a++;
            blokki1.Text = a.ToString();
        }

        private void nappi2_Click(object sender, RoutedEventArgs e)
        {
            b++;
            blokki2.Text = b.ToString();
        }
    }
}