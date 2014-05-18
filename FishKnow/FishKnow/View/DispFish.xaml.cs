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
    public partial class DispFish : PhoneApplicationPage
    {
        public DispFish()
        {
            DataContext = App.ViewModel1;
            InitializeComponent();
        }

        private void ApplicationBarMenuItem_Click_1(object sender, EventArgs e)
        {
           
        }
    }
}