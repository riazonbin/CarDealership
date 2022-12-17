using CarDealership.ADOApp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace CarDealership
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static CarDealershipEntities Connection = new CarDealershipEntities();
        public static Employee currentEmployee;
        public static DispatcherTimer dispatcherTimer = new DispatcherTimer();
    }
}
