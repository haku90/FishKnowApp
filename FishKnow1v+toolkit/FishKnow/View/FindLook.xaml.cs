using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using FishKnow.Model;
namespace FishKnow.View
{
    public partial class FindLook : PhoneApplicationPage
    {
        public FindLook()
        {
            DataContext = App.ViewModel1;
            InitializeComponent();
            
            BackKeyPress += FindLook_BackKeyPress;
            autoCompleteBox1.ItemFilter = SearchFish;
            App.ViewModel1.select = null;
            
        }
        bool SearchFish(string search, object value) 
        {
            if (value != null)
            {
                Fish dataSource = value as Fish;
                string name = dataSource.Name;
                if (name.ToLower().StartsWith(search.ToLower()))
                    return true;
                
            }
            return false;

        }
        void FindLook_BackKeyPress(object sender, System.ComponentModel.CancelEventArgs e)
        {
            App.ViewModel1.select = null;
        }

        private void autoCompleteBox1_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            
            NavigationService.Navigate(new Uri("/View/DispFish.xaml", UriKind.Relative));
           
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Nie znaleziono Rybki. Sprawdź czy wpisałeś poprawnie nazwę. Skorzystaj z podpowiedzi.","Info",MessageBoxButton.OK);


        }

        private void ApplicationBarMenuItem_Click_1(object sender, EventArgs e)
        {
            App.ViewModel1.select = null;
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));


        }

        private void ApplicationBarMenuItem_Click_2(object sender, EventArgs e)
        {
            App.ViewModel1.select = null;
            NavigationService.Navigate(new Uri("/View/EncyList.xaml", UriKind.Relative));

        }
    }
}