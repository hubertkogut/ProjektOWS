using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static OWS.Models.StrefaKlimatyczna;

namespace UnitTestProject1.Models
{
    [TestClass()]
    public class StrefaKlimatycznaTests
    {
        [TestMethod()]
        public void ZalSKlimatTest()
        {
            var list = ZalSKlimat();
            Assert.AreEqual(2, list.Count);
        }
    }
}