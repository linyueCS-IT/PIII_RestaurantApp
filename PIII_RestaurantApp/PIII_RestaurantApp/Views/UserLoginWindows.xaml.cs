using System;
using System.Collections.Generic;
using System.IO;
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
using PIII_RestaurantApp.Models;
using PIII_RestaurantApp.Services;

namespace PIII_RestaurantApp.Views
{
    /// <summary>
    /// Interaction logic for UserLoginWindows.xaml
    /// </summary>
    public partial class UserLoginWindows : Window
    {
        private Customer _customer;
        private CustomerService _customerService;

        #region Constructor
        public UserLoginWindows()
        {
            InitializeComponent();
            _customer = new Customer();
            _customerService = new CustomerService();
        }
        #endregion
        private void BtnUserLogin_Clicked(object sender, RoutedEventArgs e)
        {
            string userName = txtUsername.Text;
            string password = txtPassword.Text; 
            _customer = _customerService.IsValidateLogin(userName, password);

            if ( _customer != null )
            {
                UserMenuWindow userMenuWindow = new UserMenuWindow(_customer);
                userMenuWindow.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("username or password is not correct!");
                txtUsername.Text = null;
                txtPassword.Text = null;
            }
        }

        private void BtnUserCancel_Clicked(object sender, RoutedEventArgs e)
        {

        }

        private bool IsValidateLogin(string userName, string password)
        {
            // Check username
            if (string.IsNullOrWhiteSpace(userName))
            {
                MessageBox.Show("Username cannot be empty", "Validation Error",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                return false;
            }
            // Check password
            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Password cannot be empty", "Validation Error",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                return false;
            }
            return true;
        }
    
    }
}
