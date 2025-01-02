using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using PIII_RestaurantApp.Models;

namespace PIII_RestaurantApp.Services
{
    internal class CustomerService
    {
        private string _csvPath = "./../../Data/customer.csv";
        private List<Customer> _customerList = new List<Customer>();

        #region Constructor
        public CustomerService()
        {
            LoadCustomer();
        }
        #endregion
        #region Method
        /// <summary>
        /// Validate customer information for sign up
        /// </summary>
        /// <param name="customer"></param>
        /// <exception cref="ArgumentException"></exception>
        public void ValidateCustomer(Customer customer)
        {
            // validate username
            if (string.IsNullOrWhiteSpace(customer.Username))
                throw new ArgumentException("Username cannot be empty");
            if (IsUsernameExist(customer.Username))
                throw new ArgumentException("Username already exists");

            // validate Email
            if (string.IsNullOrWhiteSpace(customer.Email))
                throw new ArgumentException("Email cannot be empty");
            if (!IsValidEmail(customer.Email))
                throw new ArgumentException("Invalid email format");
            if (IsEmailExist(customer.Email))
                throw new ArgumentException("Email already exists");

            // validate Password
            if (!string.IsNullOrWhiteSpace(customer.Password))
                throw new ArgumentException("Password cannot be empty");           
        }
        #endregion
        #region Email

        /// <summary>
        /// System.Net.Mail is a namespace from the .NET framework that provides classes for handling email operations.
        /// MailAddress class specifically handles email address validation according to RFC 5322 standards.
        /// </summary>
        /// <param name="email"> pass a string parameter </param>
        /// <returns></returns>
        public bool IsValidEmail(string email)
        {
            try
            {
                var mailAddress = new System.Net.Mail.MailAddress(email);
                return mailAddress.Address == email;
            }
            catch
            {
                return false;
            }
            /*
             * Using Regex validate email
              string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
               return Regex.IsMatch(email, pattern);
             */
        }
        /// <summary>
        /// Validate customer's email, make sure it is unique
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public bool IsEmailExist(string email)
        {
            foreach (Customer customer in _customerList)
            {
                if (email == customer.Email)
                {
                    return true;
                }
            }
            return false;
        }

        #endregion
        #region Password        
        public bool IsValidatePassword(string password)
        {
            foreach(Customer customer in _customerList)
            {
                if( customer.Password == password )
                    return true;
            }
            return false;
        }
        #endregion

        #region username
        public bool IsUsernameExist(string username)
        {
            foreach (Customer customer in _customerList)
            {
                if (username == customer.Username)
                {
                    return true;
                }
            }
            return false;
        }
        #endregion

        #region Load customer file
        private void LoadCustomer()
        {
            using(StreamReader sr = new StreamReader(_csvPath))
            {
                // dump title line
                sr.ReadLine();
                string line;
                while((line = sr.ReadLine()) != null)
                {
                    string[] values = line.Split(',');
                    _customerList.Add(new Customer
                    {
                        Id = values[0],
                        Username = values[1],
                        Email = values[2],
                        Password = values[3],
                        FirstName = values[4],
                        LastName = values[5],
                        Phone = values[6],
                        Address = values[7]
                    });
                }
            }
        }
        #endregion

        #region Login validation
        public Customer IsValidateLogin(string username, string password)
        {            
            foreach (Customer customer in  _customerList)
            {
                if (customer.Username == username && customer.Password == password )
                    return customer;
            }
            return null;
        }
        #endregion
    }
}


