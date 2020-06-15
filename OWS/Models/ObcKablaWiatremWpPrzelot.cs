using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OWS.Models
{
    /// <summary>
    /// Klasa ObcKablaWiatremWpPrzelot to model tabeli ObcKablaWiatremWpPrzelot z bazy danych
    /// </summary>
    public class ObcKablaWiatremWpPrzelot
    {
        ///<value>propercja Id</value> 
        public int Id { get; set; }
        ///<value>propercja Typkabla</value> 
        public string TypKabla { get; set; }
        ///<value>propercja StrefaWiatrowa</value> 
        public string StrefaWiatrowa { get; set; }
        ///<value>propercja ObciążenieWp</value> 
        public float ObciazenieWp { get; set; }

    }
}
