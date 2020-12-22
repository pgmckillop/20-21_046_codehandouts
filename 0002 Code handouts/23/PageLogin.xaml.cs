using System;
using System.Windows;
using System.Windows.Controls;
using FlooringCalculator.Models;

/*
 * Title:   PageLogin
 * Author:  Paul McKillop
 * Date:    November 2020
 * Purpose: Code behind for page
 */

namespace FlooringCalculator
{
    /// <summary>
    /// Interaction logic for PageLogin.xaml
    /// </summary>
    public partial class PageLogin : Page
    {
        public PageLogin()
        {
            InitializeComponent();
            FillTempCredentials();
        }



        private void FillTempCredentials()
        {
            this.UsernameTextBox.Text = "mvance0001";
            this.PasswordTextBox.Text = "hardcodedtestpassword";
        }

        private bool CheckEntries(string username, string password)
        {
            bool valid = !(string.IsNullOrEmpty(username) && string.IsNullOrEmpty(password));

            return valid;
        }

        private void ClearButton_OnClick(object sender, RoutedEventArgs e)
        {
            UsernameTextBox.Text = "";
            PasswordTextBox.Text = "";
        }

        private void SubmitButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (CheckEntries(UsernameTextBox.Text, PasswordTextBox.Text))
            {
                try
                {
                    if (Login.Validate(UsernameTextBox.Text, PasswordTextBox.Text))
                    {
                        // -- Open PageDataEntry
                        var pageDataEntry = new PageDataEntry();
                        var navigationService = this.NavigationService;
                        navigationService?.Navigate(pageDataEntry);
                    }
                    else
                    {
                        MessageBox.Show("Credentials are incorrect. Please re-enter");
                    }
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);
                    throw;
                }
            }
        }
    }
}
