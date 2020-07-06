using OWS.Services;
using System;
using Xunit;

namespace UnitTestProject1.Services
{
    public class ValidationShould 
    {
        private readonly Validation _stu;
        public ValidationShould()
        {
            _stu = new Validation();
        }

        [Fact]
        public void valKabelTest()
        {
            int a = 0;
            Assert.Null(_stu.valKabel(a));
            int b = 11;
            Assert.Equal("Ilość kabli powinna zawierać się w przedziale od 0 do 10", _stu.valKabel(b));
        }

        [Fact]
        public void valDlugoscPrzesloTest()
        {
            int a = 13;
            Assert.Null(_stu.valDlugoscPrzylacz(a));
            int b = 111111111;
            Assert.Equal("Długość przyłączy powinna zawierać się w przedziale od 0 do 50",
                _stu.valDlugoscPrzylacz(b));
        }

        [Fact]
        public void valKatAlfaTest()
        {
            int a = 170; 
            Assert.Null(_stu.valKatAlfa(a));
            int b = 171;
            Assert.Equal("Kąt poninien zawierać się w przedziale od 0 do 170", _stu.valKatAlfa(b));
        }

        
    }
}