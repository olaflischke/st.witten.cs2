using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HistorischeWaehrungenDal
{
    public class Waehrung
    {
        public string IsoCode { get; set; }
        public double EuroKurs { get; set; }
    }
}
