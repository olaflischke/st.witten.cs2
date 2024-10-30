

using HistorischeWaehrungenDal;

namespace WaehrungsDalUnitTests
{
    public class ArchivTests
    {
        string url;

        [SetUp]
        public void Setup()
        {
            //url = "https://www.ecb.europa.eu/stats/eurofxref/eurofxref-hist-90d.xml";
            url = "https://www.ecb.europa.eu/stats/eurofxref/eurofxref-hist.xml";
        }

        [Test]
        public void KannArchivInitialisieren()
        {
            Archiv archiv = new Archiv(url);

            Handelstag? tag1 = archiv.Handelstage?.FirstOrDefault();
            Waehrung? usd = tag1?.Waehrungen?.FirstOrDefault();

            if (tag1 != null && usd != null)
            {
                Console.WriteLine($"{tag1.Datum:dd.MM.yyyy}: USD {usd.EuroKurs:#,##0.00}");
            }

            Assert.AreEqual(GetAttributeCount("time"), archiv.Handelstage.Count);
        }

        private int GetAttributeCount(string attributeName)
        {
            // TODO: Implementieren
            return 64;
        }
    }
}