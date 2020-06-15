using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OWS.Models
{
    /// <summary>
    /// Klasa Slupy to model tabeli Slupy z bazy danych
    /// posiada propercje 
    /// </summary>
    public class Slupy
    {
        ///<value>propercja Id</value> 
        public int Id { get; set; }
        ///<value>propercja TypSlupa</value> 
        public string TypSlupa { get; set;}
        ///<value>propercja WytrzymaloscW1</value> 
        public float WytrzymaloscW1 { get; set; }
        ///<value>propercja WytrzymaloscW2</value> 
        public float WytrzymaloscW2 { get; set; }
    }
}
