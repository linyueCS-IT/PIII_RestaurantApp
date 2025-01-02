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

namespace PIII_RestaurantApp.Views
{
    /// <summary>
    /// Interaction logic for UserLoginWindows.xaml
    /// </summary>
    public partial class UserLoginWindows : Window
    {
        public UserLoginWindows()
        {
            InitializeComponent();
        }

        private void BtnUserLogin_Clicked(object sender, RoutedEventArgs e)
        {
            string userName = txtUsername.Text;
            string password = txtPassword.Text;
            
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
        //private List<string> GetUsernameList()
        //{
        //    string customerCsvFilePath = "/Data/Customer.csv";

        //    StreamReader reader = new StreamReader(customerCsvFilePath);
        //}
    }
}
