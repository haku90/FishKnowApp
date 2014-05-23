﻿using System;
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

namespace FishKnow
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {

            InitializeComponent();
        }

        private void BtEncy_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/View/EncyList.xaml", UriKind.Relative));
        }

        private void BtInfo_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/View/Info.xaml", UriKind.Relative));
        }
    }
}