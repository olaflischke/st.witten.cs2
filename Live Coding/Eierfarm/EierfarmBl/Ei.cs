namespace EierfarmBl
{
    public class Ei
    {
        // Konstruktor für ein Ei
        public Ei()
        {
            
            // Ersetzt durch Auto-Property Initializer
            //this.Legedatum = DateTime.Now;

            // Instannziiert einen Zufallsgenerator
            Random random    = new Random();

            // _gewicht = 42;
            this.Gewicht = random.Next(45, 81);
            this.Farbe = EiFarbe.Gruen;
        }

        // Öffentliches Feld
        // Nicht machen!
        //public double Gewicht2;


        // Full-qualified Property (Property mit Backing Field)
        // erzeugt über "propfull" 

        // Backing Field
        private double _gewicht;

        // Öffentlicher Teil der Property
        public double Gewicht
        {
            // Accessoren der Gewicht-Property
            get { return _gewicht; }    // double g = meinEi.Gewicht;
            set
            {
                //if (value > 0) _gewicht = value;
                if (value > 0)
                {
                    _gewicht = value;
                }
            }
        }    // meinEi.Gewicht = 65;

        public EiFarbe Farbe { get; set; }

        public double GewichtInKilo
        {
            get
            {
                return this.Gewicht / 1000;
            }
        }

        // Auto-Property
        // Property mit automatisch (durch den Compiler) erzeugtem Backing Field
        public DateTime Legedatum { get; set; } = DateTime.Now; // Auto-Property Initializer (ausgeführt vor(!) Konstruktor)
    }

    public enum EiFarbe
    {
        Gruen,
        Hell,
        Dunkel
    }
}

