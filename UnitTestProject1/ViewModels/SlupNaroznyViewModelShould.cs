using System.Collections.Generic;
using System.Threading.Tasks;
using Caliburn.Micro;
using Moq;
using OWS.Models;
using OWS.Services;
using OWS.ViewModels;
using Xunit;

namespace UnitTestProject1.ViewModels
{
    public class SlupNaroznyViewModelShould
    {
        private readonly SlupNaroznyViewModel _sut;
        private readonly Mock<IValidation> _mockValidator;
        private readonly Mock<IDataAccess> _mockData;

        public SlupNaroznyViewModelShould()
        {
            _mockValidator = new Mock<IValidation>();
            _mockData = new Mock<IDataAccess>();

            _sut = new SlupNaroznyViewModel(_mockValidator.Object, _mockData.Object);
            var strefa = new StrefaKlimatyczna();
            strefa.StrefaWiatrowa = "W1";
            _sut.SelectedSWiatrowa = strefa;
        }


        [Fact]
        public void ConstructorTest()
        {
            Assert.IsType<BindableCollection<StrefaKlimatyczna>>(_sut.SKlimat);
        }


        [Fact]
        public async Task ZaladujDaneShould()
        {
            var listaKGP = new List<ObcKablaWiatremWpPrzelot>()
            {
                new ObcKablaWiatremWpPrzelot()
                {
                    ObciazenieWp = 10
                }
            };
            var listaNP = new List<NaciagPodstawowy>()
            {
                new NaciagPodstawowy()
                {
                    Naciag100 = 50
                }
            };
            var listaL = new List<ObcLatarnia>()
            {
                new ObcLatarnia()
                {
                    ObciazeniePo = 20
                }
            };
            var listaS = new List<Slupy>()
            {
                new Slupy()
                {
                    WytrzymaloscW1 = 200
                }
            };
            _mockData.Setup(x => x.ZaladujKabelGlownyPrzelotAsync("W1"))
                .ReturnsAsync(listaKGP);
            _mockData.Setup(x => x.ZaladujNaciagPodstawowyAsync())
                .ReturnsAsync(listaNP);
            _mockData.Setup(x => x.ZaladujLatarniaAsync("W1"))
                .ReturnsAsync(listaL);
            _mockData.Setup(x => x.ZaladujSlupyNarozneAsync())
                .ReturnsAsync(listaS);


            await _sut.ZaladujDane();

            Assert.Equal(listaKGP, _sut.ComboObcKablaWiatremWpPrzelot1);
            Assert.Equal(listaKGP, _sut.ComboObcKablaWiatremWpPrzelot2);
            Assert.Equal(listaKGP, _sut.ComboObcKablaWiatremWpPrzelot3);
            Assert.Equal(listaNP, _sut.ComboPrzylaczPrzelot1);
            Assert.Equal(listaNP, _sut.ComboPrzylaczPrzelot2);
            Assert.Equal(listaNP, _sut.ComboPrzylaczPrzelot3);
            Assert.Equal(listaL, _sut.ComboLatarnia);
            Assert.Equal(listaS, _sut.ComboSlupy);

            await Assert.PropertyChangedAsync(_sut, "ComboPrzylaczPrzelot4", async () =>
                await _sut.ZaladujDane());
            await Assert.PropertyChangedAsync(_sut, "ComboObcKablaWiatremWpPrzelot4", async () =>
                await _sut.ZaladujDane());
        }
    }
}