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
    /// Interaction logic for AuthorizationPage.xaml
    /// </summary>
    public partial class AuthorizationPage : Page
    {
        public AuthorizationPage()
        {
            InitializeComponent();
        }

        private void AuthorizationButtonClick(object sender, RoutedEventArgs e)
        {
            if(tbFirstname.Text != "" && tbLastname.Text != "")
            {
                var result = App.Connection.Employee.FirstOrDefault(x => x.Firstname == tbFirstname.Text 
                && x.Lastname == tbLastname.Text);
                if(result is null)
                {
                    MessageBox.Show("Нет такого пользователя!");
                    return;
                }
                App.currentEmployee = result;

                NavigationService.Navigate(new MainMenuPage());
            }
        }
    }
}
