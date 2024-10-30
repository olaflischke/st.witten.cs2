using System.Globalization;
using System.Xml.Linq;

namespace HistorischeWaehrungenDal
{
    public class Handelstag
    {
        public Handelstag(XElement handelstagNode)
        {
            this.Datum = Convert.ToDateTime(handelstagNode.Attribute("time").Value);

            NumberFormatInfo nfiEzb = new NumberFormatInfo() { NumberDecimalSeparator = "." };

            var q = handelstagNode.Elements().Select(el => new Waehrung() 
                                                {
                                                    IsoCode = el.Attribute("currency").Value,
                                                    EuroKurs = Convert.ToDouble(el.Attribute("rate").Value,NumberFormatInfo.InvariantInfo)
                                                });

            Waehrung w = new Waehrung();

            this.Waehrungen = q.ToList();
        }

        public List<Waehrung> Waehrungen { get; set; }
        public DateTime Datum { get; set; }
    }
}