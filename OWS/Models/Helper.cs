using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OWS.Models
{
    /// <summary>
    /// Klasa Helper 
    /// </summary>
    public static class Helper
    {
        /// <summary>
        /// Przechowuje ConnectionStrings
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string CnnVal(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
