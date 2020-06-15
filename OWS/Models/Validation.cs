using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OWS.Models
{
    /// <summary>
    /// Klasa Validation posiada metody wykorzystywane do walidacji w klasach SlupNaroznyViewModel oraz
    /// SplupPrzelotowyViewModel
    /// </summary>
    public class Validation
    {
        /// <summary>
        /// metoda sprawdza podaną przez użytkownika ilość kabli
        /// </summary>
        /// <param name="iloscKabel"></param>
        /// <returns> zwraca string z informacją o błędzie jeśli spełniony został warunek błędnych danych
        /// lub null</returns>
        public static string valKabel(int iloscKabel)
        {
            if (iloscKabel < 0 || iloscKabel > 10)
            {
                return "Ilość kabli powinna zawierać się w przedziale od 0 do 10";
            }
            return null;
        }

        /// <summary>
        /// metoda sprawdza podaną przez użytkownika ilość kabli przyłączeniowych
        /// </summary>
        /// <param name="iloscPrzylacz"></param>
        /// <returns> zwraca string z informacją o błędzie jeśli spełniony został warunek błędnych danych
        /// lub null</returns>
        public static string valPrzylacz(int iloscPrzylacz)
        {
            if (iloscPrzylacz < 0 || iloscPrzylacz > 10)
            {
                return "Ilość przyłączy powinna zawierać się w przedziale od 0 do 10";
            }
            return null;
        }

        /// <summary>
        /// metoda sprawdza podaną przez użytkownika dlugość kabla przyłączeniowego
        /// </summary>
        /// <param name="dlugosc"></param>
        /// <returns> zwraca string z informacją o błędzie jeśli spełniony został warunek błędnych danych
        /// lub null</returns>
        public static string valDlugoscPrzylacz(int dlugosc)
        {
            if (dlugosc < 0 || dlugosc > 50)
            {
                return "Długość przyłączy powinna zawierać się w przedziale od 0 do 50";
            }
            return null;
        }

        /// <summary>
        /// metoda sprawdza podaną przez użytkownika dlugość kabla głównego
        /// </summary>
        /// <param name="dlugosc"></param>
        /// <returns> zwraca string z informacją o błędzie jeśli spełniony został warunek błędnych danych
        /// lub null</returns>
        public static string valDlugoscPrzeslo(int dlugosc)
        {
            if (dlugosc < 0 || dlugosc > 100)
            {
                return "Długość przęsła powinna zawierać się w przedziale od 0 do 100";
            }
            return null;
        }

        /// <summary>
        /// metoda sprawdza podaną przez użytkownika nazwę słupa
        /// </summary>
        /// <param name="nr"></param>
        /// <returns> zwraca string z informacją o błędzie jeśli spełniony został warunek błędnych danych
        /// lub null</returns>
        public static string valNrSlupa(string nr)
        {
            if (nr.Length > 40)
            {
                return "Numer słupa nie może przekraczać 40 znaków";
            }
            if (nr.Length < 1)
            {
                return "Wprowadź numer słupa";
            }
            return null;
        }

        /// <summary>
        /// metoda sprawdza podany przez użytkownika kąt w słupie narożnym
        /// </summary>
        /// <param name="kat"></param>
        /// <returns> zwraca string z informacją o błędzie jeśli spełniony został warunek błędnych danych
        /// lub null</returns>
        public static string valKatAlfa(int kat)
        {
            if (kat < 0 || kat > 170)
            {
                return "Kąt poninien zawierać się w przedziale od 0 do 170";
            }

            return null;
        }
    }
}