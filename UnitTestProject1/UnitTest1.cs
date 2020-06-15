using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OWS.Models;
using System.Configuration;
using OWS.ViewModels;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
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
            float oczekiwane = 30;
            float rzeczywiste;
            float x = 55;
            rzeczywiste = NaciagPodstawowy.Naciag(x, z);
            Assert.AreEqual(oczekiwane, rzeczywiste);
        }

        [TestMethod]
        public void StrefyTest()
        {
            SlupPrzelotowyViewModel A = new SlupPrzelotowyViewModel();
            int B = A.SKlimat.Count;
            int C = 2;
            Assert.AreEqual(C, B);
        }


      


    }

}
