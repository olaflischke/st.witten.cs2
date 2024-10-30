using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace EierfarmBl
{
    public abstract class Vogel : INotifyPropertyChanged, IEiLeger
    {
        private double _gewicht;

        private string name;

        public event PropertyChangedEventHandler? PropertyChanged;
        public ObservableCollection<Ei> Eier { get; set; } = new ObservableCollection<Ei>();

        public double Gewicht
        {
            get
            {
                return _gewicht;
            }
            set
            {
                _gewicht = value;
                OnPropertyChanged("Gewicht");
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }

        public DateTime Schluepfdatum { get; set; }

        private void OnPropertyChanged(string propName)
        {
            //if (PropertyChanged != null)
            //    PropertyChanged(this, new PropertyChangedEventArgs(propName));

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }

        public abstract void Fressen();

        public abstract void EiLegen();
    }
}