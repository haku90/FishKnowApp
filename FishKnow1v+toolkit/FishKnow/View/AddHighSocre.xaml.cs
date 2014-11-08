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
    public partial class AddHighSocre : PhoneApplicationPage
    {
        public AddHighSocre()
        {
            InitializeComponent();
        }

        private void btAddScore_Click(object sender, RoutedEventArgs e)
        {
            string nam = tbxName.Text;
            string sco =  tbxScore.Text;
            HighScoreDatabaseAdd add = new HighScoreDatabaseAdd();
           // if (!String.IsNullOrEmpty(nam) && !String.IsNullOrEmpty(sco))
                add.Addhs(nam,sco);
        }
    }
}