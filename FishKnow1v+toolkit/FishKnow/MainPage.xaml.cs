using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using FishKnow.ViewModel;
using FishKnow.Model;

namespace FishKnow
{


    public partial class MainPage : PhoneApplicationPage
    {
       

        // Constructor
        public MainPage()
        {
           
            InitializeComponent();
            BackKeyPress += MainPage_BackKeyPress;
            using (HighScoreDataContext context = new HighScoreDataContext(HighScoreDataContext.DBConnectionString))
            {
                if (!context.DatabaseExists())
                    context.CreateDatabase();
            }
            
        }

      
        void MainPage_BackKeyPress(object sender, System.ComponentModel.CancelEventArgs e)
        {
           
        }

        private void BtEncy_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/View/EncyList.xaml", UriKind.Relative));
        }

        private void BtWyniki_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/View/DispHighScore.xaml", UriKind.Relative));
        }
    }
}