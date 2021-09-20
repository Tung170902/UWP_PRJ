using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using T2008M_UWP.Models;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace T2008M_UWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Layout : Page
    {
        public static Frame _mainFrame;
        public Layout()
        {
            this.InitializeComponent();
            _mainFrame = MainFrame;
        }
        private void Home(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(typeof(Pages.Home));
        }
        private void EatIn(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(typeof(Pages.EatIn));
        }
        private void Collection(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(typeof(Pages.Collection));
        }
        private void Delivery(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(typeof(Pages.Delivery));
        }
        private void TakeAway(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(typeof(Pages.TakeAway));
        }
        private void DiverPayment(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(typeof(Pages.DriverPayment));
        }
        private void Customer(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(typeof(Pages.Customer));
        }

        private void FontIcon_Tapped(object sender, TappedRoutedEventArgs e)
        {
            SP.IsPaneOpen = !SP.IsPaneOpen;

        }

        private void Menu_Loaded(object sender, RoutedEventArgs e)
        {
            var item1 = new MenuItem() { Name = "Home", MenuPage = "home" };
            var item2 = new MenuItem() { Name = "EatIn", MenuPage = "ei" };
            var item3 = new MenuItem() { Name = "Collection", MenuPage = "collection" };
            var item4 = new MenuItem() { Name = "Delivery", MenuPage = "delivery" };
            var item5 = new MenuItem() { Name = "TakeAway", MenuPage = "ta" };
            var item6 = new MenuItem() { Name = "DriverPayment", MenuPage = "dp" };
            var item7 = new MenuItem() { Name = "Customer", MenuPage = "customer" };
            Menu.Items.Add(item1);
            Menu.Items.Add(item2);
            Menu.Items.Add(item3);
            Menu.Items.Add(item4);
            Menu.Items.Add(item5);
            Menu.Items.Add(item6);
            Menu.Items.Add(item7);
            
        }

        private void ListViewItem_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MenuItem selectedItem = (MenuItem)Menu.SelectedItem;
            switch (selectedItem.MenuPage)
            {
                case "home": MainFrame.Navigate(typeof(Pages.Home)); break;
                case "ei": MainFrame.Navigate(typeof(Pages.EatIn)); break;
                case "collection": MainFrame.Navigate(typeof(Pages.Collection)); break;
                case "delivery": MainFrame.Navigate(typeof(Pages.Delivery)); break;
                case "ta": MainFrame.Navigate(typeof(Pages.TakeAway)); break;
                case "dp": MainFrame.Navigate(typeof(Pages.DriverPayment)); break;
                case "customer": MainFrame.Navigate(typeof(Pages.Customer)); break;
            }
        }
    }
}
