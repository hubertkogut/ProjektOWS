using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OWS.Models
{
    /// <summary>
    /// Klasa ObcLatarnia to model tabeli ObcLatarnia z bazy danych
    /// posiada propercje
    /// </summary>
    public class ObcLatarnia
    {
        ///<value>propercja Id</value> 
        public int Id { get; set; }
        ///<value>propercja Latarnia</value> 
        public string Latarnia { get; set; }
        ///<value>propercja StrefaWiatrowa</value> 
        public string StrefaWiatrowa {get; set;}
        ///<value>propercja ObciazeniePo</value> 
        public float ObciazeniePo { get; set; }
    }
}
