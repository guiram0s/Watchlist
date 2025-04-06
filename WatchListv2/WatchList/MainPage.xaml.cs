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
using WatchList.View;

namespace WatchList
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
            lblMain.Content = Session.UserName;

            HomeView v = new HomeView();
            ContentView.Content = v;
        }

        private void ChangeToHome(object sender, RoutedEventArgs e)
        {
            HomeView v = new HomeView();
            ContentView.Content = v;
            
            lblMain.Content = Session.UserName;
        }

        private void ChangeToDiscovery(object sender, RoutedEventArgs e)
        {
            DiscoveryView u2 = new DiscoveryView();
            ContentView.Content = u2;
           
            lblMain.Content = Session.UserName;
        }

        private void ChangeToList(object sender, RoutedEventArgs e)
        {
            View.ListView u2 = new View.ListView();
            ContentView.Content = u2;
            
            lblMain.Content = Session.UserName;
        }

        private void ChangeToAccount(object sender, RoutedEventArgs e)
        {
            AccountView u2 = new AccountView();
            ContentView.Content = u2;
            lblMain.Content = Session.UserName;
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
