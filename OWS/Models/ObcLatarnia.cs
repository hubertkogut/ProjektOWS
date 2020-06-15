using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OWS.Models
{
    /// <summary>
    /// Klasa ObcLatarnia to model tabeli ObcLatarnia z bazy danych
    /// </summary>
    public class ObcLatarnia
    {
        public int Id { get; set; }
        public string Latarnia { get; set; }
        public string StrefaWiatrowa { get; set; }
        public float ObciazeniePo { get; set; }
    }
}
