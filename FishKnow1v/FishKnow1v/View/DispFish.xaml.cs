using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace FishKnow1v.View
{
    public partial class DispFish : PhoneApplicationPage
    {
        public DispFish()
        {
            DataContext = App.ViewModel1;
            InitializeComponent();
            BackKeyPress += DispFish_BackKeyPress;
        }

        void DispFish_BackKeyPress(object sender, System.ComponentModel.CancelEventArgs e)
        {
            App.ViewModel1.select = null;
        }

        private void ApplicationBarMenuItem_Click_1(object sender, EventArgs e)
        {
            App.ViewModel1.select = null;
            NavigationService.GoBack();  
        }

        private void ApplicationBarMenuItem_Click_2(object sender, EventArgs e)
        {
            App.ViewModel1.select = null;
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }

        private void ApplicationBarIconButton_Click_1(object sender, EventArgs e)
        {
            
            NavigationService.Navigate(new Uri("/View/FindLook.xaml", UriKind.Relative));
            App.ViewModel1.select = null;
        }
    }
}