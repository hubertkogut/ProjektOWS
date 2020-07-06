using System.Collections.Generic;
using System.Threading.Tasks;
using Moq;
using OWS.Models;
using OWS.Services;
using OWS.ViewModels;
using Xunit;

namespace UnitTestProject1.ViewModels
{
    
    public class TabelaObliczoneSlupyViewModelShould
    {
        
        [Fact]
        public async Task ZaladujTabeleTest()
        {
            List<ObliczoneSlupy> listaObliczoneSlupy = new List<ObliczoneSlupy>
            {
                new ObliczoneSlupy
                {
                    Id = 1,
                    NrProjektu = "Rze-Rze13-1313",
                    NrSlupa = "RZE T13 12/1/13",
                    Pu = 100,
                    Pud = 200,
                    TypSlupa = "S. przelotowy",
                    Wynik = "Słup spełnia warunek"
                }
            };

            var mock = new Mock<IDataAccess>();
            mock.Setup(x => x.ZaladujTabeleAsync(It.IsAny<string>()))
                .ReturnsAsync(listaObliczoneSlupy);

           var sut = new TabelaObliczoneSlupyViewModel(mock.Object);

           await sut.ZaladujTabele();

           Assert.Equal(listaObliczoneSlupy, sut.Tabela);

           await Assert.PropertyChangedAsync(sut, "Tabela", async () => await sut.ZaladujTabele());

        }
    }
}