using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OWS.Models;
using OWS.Services;

namespace OWS.ViewModels
{
    class ShellViewModel : Conductor<object>
    {
        /// <summary>
        /// Metody odpowiedzialne za ładowanie odpowiednich UserControl
        /// </summary>


        private IValidation _valid;

        private IDataAccess _data;

        public ShellViewModel(IValidation valid, IDataAccess data)
        {
            _valid = valid;
            _data = data;
        }

        public void LoadPageOne()
        {
            ActivateItem(new SlupPrzelotowyViewModel(_valid, _data));
        }
        public void LoadSlupNarozny()
        {
            ActivateItem(new SlupNaroznyViewModel(_valid, _data));
        }
        public void LoadPageTwo()
        {
            ActivateItem(new TabelaObliczoneSlupyViewModel(_data));
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