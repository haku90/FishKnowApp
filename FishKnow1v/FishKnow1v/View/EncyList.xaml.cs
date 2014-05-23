using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using FishKnow.View;
using FishKnow.ViewModel;
using FishKnow.Model;
namespace FishKnow1v.View
{
    public partial class EncyList : PhoneApplicationPage
    {
        
        public EncyList()
        {

            DataContext = App.ViewModel1;
            InitializeComponent();
            BackKeyPress += EncyList_BackKeyPress;
           
        }

        void EncyList_BackKeyPress(object sender, System.ComponentModel.CancelEventArgs e)
        {
           
        }

      
       

        private void ListBox_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            
        }

        private void KListFish_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //if (listRybki.selecteItem) App.ViewModel.Nazwarybki = listRybki.selectedItem.name
            NavigationService.Navigate(new Uri("/View/DispFish.xaml", UriKind.Relative));
            
        }

        private void ApplicationBarMenuItem_Click_1(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }

        private void ApplicationBarIconButton_Click_1(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/View/FindLook.xaml", UriKind.Relative));

        }

      
        
     
        

    }
}