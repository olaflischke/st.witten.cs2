using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EierfarmBl
{
    public class Huhn
    {
        public string Name { get; set; }
        public DateTime Schluepfdatum { get; set; }
        public double Gewicht { get; set; }
        public List<Ei> Eier { get; set; } = new List<Ei>();


        public void Fressen()
        {
            if (this.Gewicht < 3000)
            {
                // Gewicht = Gewicht + 100;
                this.Gewicht += 100;
            }
        }

        public void EiLegen()
        {
            if (this.Gewicht > 1500)
            {
                // Typ Variable = Wert;
                Ei ei = new Ei(); // ruft den Konstruktor der Ei-Klasse auf
                this.Gewicht -= ei.Gewicht;
                this.Eier.Add(ei);
            }
        }
    }
}
