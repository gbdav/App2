using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace App2.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        private string _nombre;
        public MainPageViewModel()
        {
            _nombre = "Hola";
        }
        public string Nombre
        {
            get => _nombre;
            set
            {
                if (string.Equals(_nombre, value)) return;

                _nombre = value;
                RaisedPropertyChanged(nameof(Nombre));

                RaisedPropertyChanged(nameof(SinUpdate));

            }

        }
        public string SinUpdate
        {
            get => _nombre;
        }
    }
}
