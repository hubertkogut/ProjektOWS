using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OWS.ViewModels
{
    class ShellViewModel : Conductor<object>
    {
        /// <summary>
        /// Metody odpowiedzialne za ładowanie odpowiednich UserControl
        /// </summary>
        public void LoadPageOne()
        {
            ActivateItem(new SlupPrzelotowyViewModel());
        }
        public void LoadSlupNarozny()
        {
            ActivateItem(new SlupNaroznyViewModel());
        }
        public void LoadPageTwo()
        {
            ActivateItem(new TabelaObliczoneSlupyViewModel());
        }
        public void LoadStrefaWiatrowa()
        {
            ActivateItem(new StrefaWiatrowaWViewModel());
        }
        public void LoadStrefaSadziowa()
        {
            ActivateItem(new StrefaSadziowaSViewModel());
        }
    }
}