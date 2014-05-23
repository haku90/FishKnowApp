using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FishKnow1v.Model;
using FishKnow1v.ViewModel;
using FishKnow1v.View;
using System.ComponentModel;

namespace FishKnow1v.ViewModel
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
