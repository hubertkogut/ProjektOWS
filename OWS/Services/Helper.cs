using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OWS.Services
{
    /// <summary>
    /// Klasa Helper pobierająca connectionStringa
    /// </summary>
    public static class Helper
    {
        /// <summary>
        /// Przechowuje ConnectionStrings
        /// </summary>
        /// <param name="name"></param>
        public static string CnnVal(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
