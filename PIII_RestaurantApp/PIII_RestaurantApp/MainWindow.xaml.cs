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
using PIII_RestaurantApp.Views;

namespace PIII_RestaurantApp
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

        private void btnUserOrderMenu_Clicked(object sender, RoutedEventArgs e)
        {

        }

        private void btnUserLogin_Clicked(object sender, RoutedEventArgs e)
        {
            UserLoginWindows userLoginWindows = new UserLoginWindows();
            userLoginWindows.Show();
            this.Close();
        }
    }
}
