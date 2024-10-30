using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EierfarmBl
{
    public class Huhn : Vogel
    {

        public Huhn(string name)
        {
            this.Name = name;
            this.Gewicht = 1000;
            this.Schluepfdatum = DateTime.Now;
        }


        public override void Fressen()
        {
            if (this.Gewicht < 3000)
            {
                // Gewicht = Gewicht + 100;
                this.Gewicht += 100;
            }
        }

        public override void EiLegen()
        {
            if (this.Gewicht > 1500)
            {
                // Typ Variable = Wert;
                Ei ei = new Ei(this); // ruft den Konstruktor der Ei-Klasse auf
                this.Gewicht -= ei.Gewicht;
                this.Eier.Add(ei);
            }
        }
    }
}
