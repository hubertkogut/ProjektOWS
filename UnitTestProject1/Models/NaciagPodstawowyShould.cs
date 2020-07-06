using OWS.Models;
using Xunit;
using static OWS.Models.NaciagPodstawowy;

namespace UnitTestProject1.Models
{
    
    public class NaciagPodstawowyShould
    {
        [Theory]
        [InlineData(55, 40)]
        [InlineData(12.13, 20)]
        [InlineData(76.2, 50)]
        [InlineData(99, 50)]
        public void NaciagTest(float x, int ex)
        {

            NaciagPodstawowy z = new NaciagPodstawowy
            {
                Naciag35 = 20,
                Naciag50 = 30,
                Naciag75 = 40,
                Naciag100 = 50
            };
            float ac;
            ac = Naciag(x, z);
            Assert.Equal(ex, ac);
        }
    }
}