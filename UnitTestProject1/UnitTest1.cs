using Caliburn.Micro;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OWS.Models;
using OWS.Services;
using OWS.ViewModels;

namespace UnitTestProject1
{
    //[TestClass]
    //public class UnitTest1
    //{
    //    [TestMethod]
    //    public void NaciagTest()
    //    {

    //        NaciagPodstawowy z = new NaciagPodstawowy
    //        {
    //            Naciag35 = 20,
    //            Naciag50 = 30,
    //            Naciag75 = 40,
    //            Naciag100 = 50
    //        };
    //        float oczekiwane = 30;
    //        float rzeczywiste;
    //        float x = 55;
    //        rzeczywiste = NaciagPodstawowy.Naciag(x, z);
    //        Assert.AreEqual(oczekiwane, rzeczywiste);
    //    }

    //    [TestMethod]
    //    public void StrefyTest()
    //    {
    //        SlupPrzelotowyViewModel a = new SlupPrzelotowyViewModel();
    //        int b = a.SKlimat.Count;
    //        int c = 2;
    //        Assert.AreEqual(c, b);
    //    }

    //    [TestMethod]
    //    public void valKatAlfaTest()
    //    {
    //        int a = 170;
    //        Assert.IsNull(Validation.valKatAlfa(a));
    //    }

    //    [TestMethod]
    //    public void ZaladujSlupyTest()
    //    {
    //        DataAccess da = new DataAccess();
    //        BindableCollection<Slupy> ComboSlupy;
    //        ComboSlupy = new BindableCollection<Slupy>(da.ZaladujSlupy());
    //        Assert.AreEqual(15, ComboSlupy.Count);
    //    }

    //    [TestMethod]
    //    public void ZaladujTabeleTest()
    //    {
    //        DataAccess da = new DataAccess();
    //        BindableCollection<ObliczoneSlupy> tabela;
    //        tabela = new BindableCollection<ObliczoneSlupy>(da.ZaladujTabele());
    //        Assert.IsNotNull(tabela);
    //    }

    //    [TestMethod]
    //    public void ZaladujLatarniaTest()
    //    {
    //        DataAccess da = new DataAccess();
    //        BindableCollection<ObcLatarnia> latarnia;
    //        latarnia = new BindableCollection<ObcLatarnia>(da.ZaladujLatarnia("W1"));
    //        float x = latarnia[1].ObciazeniePo;
    //        Assert.AreEqual(x, 22);
    //    }

    //    [TestMethod]
    //    public void ZaladujNaciagPodstawowyTest()
    //    {
    //        DataAccess da = new DataAccess();
    //        BindableCollection<NaciagPodstawowy> naciag;
    //        naciag = new BindableCollection<NaciagPodstawowy>(da.ZaladujNaciagPodstawowy());
    //        Assert.AreEqual(13, naciag.Count);
    //    }

    //    [TestMethod]
    //    public void ZaladujKabelGlownyPrzelotTest()
    //    {
    //        DataAccess da = new DataAccess();
    //        BindableCollection<ObcKablaWiatremWpPrzelot> glowny;
    //        glowny = new BindableCollection<ObcKablaWiatremWpPrzelot>(da.ZaladujKabelGlownyPrzelot("W1"));
    //        Assert.IsNotNull(glowny);
    //    }
    //}
}