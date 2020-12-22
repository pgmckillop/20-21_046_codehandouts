using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using FlooringCalculator.Models;

/*
 * Title:   PageSummary
 * Author:  Paul McKillop
 * Date:    November 2020
 * Purpose: Page code behind
 */

namespace FlooringCalculator
{
    /// <summary>
    /// Interaction logic for PageSummary.xaml
    /// </summary>

    public partial class PageSummary : Page
    {
        DataSummary dataSummary = new DataSummary();

        public PageSummary(DataSummary summary)
        {
            InitializeComponent();

            dataSummary = summary;

            HelpTextBlock.Text = dataSummary.SummaryForDisplay();

        }


        private void BackButton_OnClick(object sender, RoutedEventArgs e)
        {
            var pageDataEntry = new PageDataEntry();
            var navigationService = NavigationService;
            if (navigationService != null) navigationService.Navigate(pageDataEntry);
        }

        private void ExitButton_OnClick(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
