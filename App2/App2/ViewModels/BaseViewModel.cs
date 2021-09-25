using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace App2.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisedPropertyChanged (string nombrePropiedad)
        {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nombrePropiedad));
        }
    }
}
