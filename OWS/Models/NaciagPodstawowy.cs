using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OWS.Models
{
    /// <summary>
    /// Klasa NaciagPodstawowy to model tabeli NaciagPodstawowy z bazy danych
    /// </summary>
    public class NaciagPodstawowy
    {
        ///<value>propercja Id</value>  
        public int Id { get; set; }
        ///<value>propercja TypKabla</value> 
        public string TypKabla { get; set; }
        ///<value>propercja Naciag35 - Nciąg dla kabla do 35m</value> 
        public float Naciag35 { get; set; }
        ///<value>propercja Naciag50 - Nciąg dla kabla do 50m</value> 
        public float Naciag50 { get; set; }
        ///<value>propercja Naciag57 - Nciąg dla kabla do 75m</value> 
        public float Naciag75 { get; set; }
        ///<value>propercja Naciag100 - Nciąg dla kabla do 100m</value> 
        public float Naciag100 { get; set; }
        ///<value>propercja NaciagPods - naciąg brany do obliczeń, po uwzględnieniu długości kabla</value> 
        public float NaciagPods { get; set; }

        /// <summary>
        /// metoda sprawdza dlugość przyłącza i wybiera odpowiedzni naciąg do obliczeń
        /// </summary>
        /// <param name="x"></param>
        /// <param name="e"></param>
        /// <returns> zwraca naciąg kabla, dla danej długości przyłącza </returns>
        public static float Naciag(float x, NaciagPodstawowy e)
        {
            if (x < 35) { e.NaciagPods = e.Naciag35; }
            else if (x >= 35 || x < 50) { e.NaciagPods = e.Naciag50; }
            else if (x >= 50 || x < 75) { e.NaciagPods = e.Naciag75; }
            else if (x >= 75) { e.NaciagPods = e.Naciag100; }
            return e.NaciagPods;

        }
    }
}