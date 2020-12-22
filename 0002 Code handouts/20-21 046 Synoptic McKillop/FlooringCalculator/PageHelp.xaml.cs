using System.Windows;
using System.Windows.Controls;

/*
 * Title:   PageHelp
 * Author:  Paul McKillop
 * Date:    November 2020
 * Purpose: Code behind for page
 */

namespace FlooringCalculator
{
    /// <summary>
    /// Interaction logic for PageHelp.xaml
    /// </summary>
    public partial class PageHelp : Page
    {
        public PageHelp()
        {
            InitializeComponent();

            HelpTextBlock.Text = HelpText();
        }

        private void CloseButton_OnClick(object sender, RoutedEventArgs e)
        {
            var pageDataEntry = new PageDataEntry();
            if (NavigationService != null) NavigationService.Navigate(pageDataEntry);


        }

        private string HelpText()
        {
            return "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. " +
                   "Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit " +
                   "in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
        }

    }
}
