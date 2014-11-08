using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using FishKnow.ViewModel;

namespace FishKnow.View
{
    public partial class DispHighScore : PhoneApplicationPage
    {
        public DispHighScore()
        {
            InitializeComponent();
            FetchHighSocreDatabase fetch = new FetchHighSocreDatabase();
            allhs.ItemsSource = fetch.geths();
        }

       

        private void AddBtAppBar_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/View/AddHighSocre.xaml", UriKind.Relative));
        }
    }
}