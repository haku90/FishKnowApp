using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace FishKnow.View
{
    public partial class FindLook : PhoneApplicationPage
    {
        public FindLook()
        {
            DataContext = App.ViewModel1;
            InitializeComponent();
        }

        private void autoCompleteBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/View/DispFish.xaml", UriKind.Relative));
        }
    }
}