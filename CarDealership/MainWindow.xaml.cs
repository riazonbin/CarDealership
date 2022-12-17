using CarDealership.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace CarDealership
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            StartTimer();
            MainFrame.Navigate(new AuthorizationPage());
        }

        void StartTimer()
        {
            App.dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            App.dispatcherTimer.Interval = new TimeSpan(0, 0, 30);
            App.dispatcherTimer.Start();
        }
        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            CreateNewRequest();

        }

        private void CreateNewRequest()
        {
            Random random = new Random();

            var autoList = App.Connection.Car.ToList();
            var randomCar = autoList[random.Next(0, autoList.Count)];

            var customersList = App.Connection.Customer.ToList();
            var randomCustomer = customersList[random.Next(0, customersList.Count)];

            App.Connection.Request.Add(new ADOApp.Request
            {
                Car = randomCar,
                Customer = randomCustomer,
                RequestStatus_Id = 3
            });
            App.Connection.SaveChanges();

        }

    }
}
