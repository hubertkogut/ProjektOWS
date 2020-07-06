using System.Collections.Generic;
using OWS.Models;
using Xunit;
using static OWS.Models.StrefaKlimatyczna;

namespace UnitTestProject1.Models
{
    public class StrefaKlimatycznaShould
    {
        [Fact]
        public void ZalSKlimatTest()
        {
            var list = ZalSKlimat();

            Assert.Equal(2, list.Count);
        }
    }
}