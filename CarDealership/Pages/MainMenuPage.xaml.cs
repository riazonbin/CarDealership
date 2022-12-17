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

namespace CarDealership.Pages
{
    /// <summary>
    /// Interaction logic for MainMenuPage.xaml
    /// </summary>
    public partial class MainMenuPage : Page
    {
        public MainMenuPage()
        {
            InitializeComponent();
        }

        private void RequestsButtonPage(object sender, RoutedEventArgs e)
        {
            employeeFrame.Navigate(new RequestsPage());
        }

        private void SalesButtonPage(object sender, RoutedEventArgs e)
        {
            employeeFrame.Navigate(new SalesPage());
        }

        private void LogoutButtonPage(object sender, RoutedEventArgs e)
        {
            employeeFrame.Navigate(new AuthorizationPage());
            App.currentEmployee= null;
        }
    }
}
