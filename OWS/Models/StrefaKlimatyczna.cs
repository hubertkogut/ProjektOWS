using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;

namespace OWS.Models
{
    /// <summary>
    /// Klasa StrefaKlimatyczna
    /// </summary>
    public class StrefaKlimatyczna
    {
        ///<value>propercja Strefa Wiatrowa</value> 
        public string StrefaWiatrowa { get; set; }
        ///<value>propercja StrefaSadziowa</value> 
        public string StrefaSadziowa { get; set; }

        /// <summary>
        /// metoda ZalSklimat tworzy liste typu StrefaKlimatyczna, Lista inicjalizowana jest przez 2
        /// obiekty typu StrefaKlimatyczna 
        /// </summary>
        /// <returns>zwraca Liste typu StrefaKlimatyczna</returns>
        public List<StrefaKlimatyczna> ZalSKlimat()
        {
            {
                var Lista = new List<StrefaKlimatyczna>
                {
                    new StrefaKlimatyczna()
                    {

                        StrefaWiatrowa = "W1",
                        StrefaSadziowa = "S1"
                    },
                    new StrefaKlimatyczna()
                    {

                        StrefaWiatrowa = "W2",
                        StrefaSadziowa = "S2"
                    }
                };
                return Lista;
            }
        }
    }
}
