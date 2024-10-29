
using System.Xml.Linq;

namespace HistorischeWaehrungenDal
{
    /// <summary>
    /// Stellt ein Archiv dar
    /// </summary>
    public class Archiv
    {
        // Konstruktor
        // Archiv meinArchiv = new Archiv("http://....");
        // ListBox1.DataSource = meinArchiv.Handelstage;

        /// <summary>
        /// Erzeugt eine Instanz der Archivklasse mit der gg. GESMES-XML-Datei.
        /// </summary>
        /// <param name="url">URL einer GEMES-XML-Datei.</param>
        public Archiv(string url)
        {
            this.Handelstage = LiesEzbXml(url);
        }

        // VB.NET: Private Function LiesEzbXml(url As String) as List(Of Handelstag)
        private List<Handelstag>? LiesEzbXml(string url)
        {
            XDocument xmlDokument = XDocument.Load(url);

            var q = xmlDokument.Root.Descendants()
                                    .Where(xe => xe.Name == "Cube" && xe.Attributes().Count() == 1)
                                    // Projektion
                                    .Select(xe => new Handelstag(xe));

            //List<Handelstag> tage = new List<Handelstag>();

            //foreach (XElement xe in q)
            //{
            //    Handelstag tag = new Handelstag() { Datum = Convert.ToDateTime(xe.Attribute("time").Value) };
            //    tage.Add(tag);
            //}

            return q.ToList();
        }

        /// <summary>
        /// Die Handelstage, die von dieser Archiv-Instanz verwaltet werden
        /// </summary>
        public List<Handelstag>? Handelstage { get; set; }
    }
}
