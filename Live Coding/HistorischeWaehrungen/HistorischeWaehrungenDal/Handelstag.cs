using System.Xml.Linq;

namespace HistorischeWaehrungenDal
{
    public class Handelstag
    {
        public Handelstag(XElement handelstagNode)
        {
            this.Datum = Convert.ToDateTime(handelstagNode.Attribute("time").Value);

            // var q = ...
            // this.Waehrungen = q.Tolist()
        }

        public List<Waehrung> Waehrungen { get; set; }
        public DateTime Datum { get; set; }
    }
}