using Microsoft.VisualStudio.TestTools.UnitTesting;
using OWS.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1.Services
{
    [TestClass()]
    public class ValidationTests
    {
        Validation val = new Validation();

        [TestMethod()]
        public void valKabelTest()
        {
            int a = 0;
            Assert.IsNull(val.valKabel(a));
            int b = 11;
            Assert.AreEqual("Ilość kabli powinna zawierać się w przedziale od 0 do 10", val.valKabel(b));
        }

        [TestMethod()]
        public void valDlugoscPrzesloTest()
        {
            int a = 13;
            Assert.IsNull(val.valDlugoscPrzylacz(a));
            int b = 111111111;
            Assert.AreEqual("Długość przyłączy powinna zawierać się w przedziale od 0 do 50",
                val.valDlugoscPrzylacz(b));
        }

        [TestMethod()]
        public void valKatAlfaTest()
        {
            int a = 170; 
            Assert.IsNull(val.valKatAlfa(a));
            int b = 171;
            Assert.AreEqual("Kąt poninien zawierać się w przedziale od 0 do 170", val.valKatAlfa(b));
        }

    }
}