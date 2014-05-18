using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FishKnow.Model;
using FishKnow.ViewModel;
using FishKnow.View;
using System.ComponentModel;
namespace FishKnow.ViewModel
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        

            public event PropertyChangedEventHandler PropertyChanged;
            public void changeValue(string propertyName)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
                }
            }

        
    }
}
