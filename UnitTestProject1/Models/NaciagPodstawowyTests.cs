using Microsoft.VisualStudio.TestTools.UnitTesting;
using OWS.Models;
using static OWS.Models.NaciagPodstawowy;

namespace UnitTestProject1.Models
{
    [TestClass()]
    public class NaciagPodstawowyTests
    {
        [TestMethod]
        public void NaciagTest()
        {

            NaciagPodstawowy z = new NaciagPodstawowy
            {
                Naciag35 = 20,
                Naciag50 = 30,
                Naciag75 = 40,
                Naciag100 = 50
            };
            float ex = 30;
            float ac;
            float x = 55;
            ac = Naciag(x, z);
            Assert.AreEqual(ex, ac);
        }
    }
}