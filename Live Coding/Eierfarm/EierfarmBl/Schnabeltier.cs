using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace EierfarmBl
{
    public class Schnabeltier : Saeugetier, IEiLeger
    {
        public ObservableCollection<Ei> Eier { get; set; }
        public double Gewicht { get; set; }

        public void EiLegen()
        {
            throw new NotImplementedException();
        }

        public void Fressen()
        {
            throw new NotImplementedException();
        }

        public override void Saeugen()
        {
            throw new NotImplementedException();
        }
    }
}