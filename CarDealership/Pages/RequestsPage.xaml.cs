using CarDealership.ADOApp;
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
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CarDealership.Pages
{
    /// <summary>
    /// Interaction logic for RequestsPage.xaml
    /// </summary>
    public partial class RequestsPage : Page
    {
        public RequestsPage()
        {
            InitializeComponent();
            lvRequests.ItemsSource = App.Connection.Request.ToList().Where(x => x.RequestStatus_Id == 3 && x.Car.Count != 0);

            App.dispatcherTimer.Tick += new EventHandler((s, e) => lvRequests.ItemsSource = App.Connection.Request.
            ToList().Where(x => x.RequestStatus_Id == 3));
        }

        private void GrantRequest(object sender, RoutedEventArgs e)
        {
            var boundData = (Request)((Button)sender).DataContext;

            if(boundData.Car.Count == 0)
            {
                MessageBox.Show("Нет в наличии!");
                return;
            }

            boundData.RequestStatus_Id = 1;

            App.Connection.Sale.Add(new Sale
            {
                Sale_Id = boundData.Request_Id,
                Employee = App.currentEmployee,
                Request = boundData,
                Sale_Date = DateTime.Now
            });

            App.Connection.SaveChanges();
            lvRequests.ItemsSource = App.Connection.Request.ToList().Where(x => x.RequestStatus_Id == 3);
        }

        private void DenyRequest(object sender, RoutedEventArgs e)
        {
            var boundData = (Request)((Button)sender).DataContext;


            App.Connection.Request.FirstOrDefault(x => x.Request_Id == boundData.Request_Id).RequestStatus_Id = 2;

            App.Connection.SaveChanges();

            lvRequests.ItemsSource = App.Connection.Request.ToList().Where(x => x.RequestStatus_Id == 3);
        }
    }
}
