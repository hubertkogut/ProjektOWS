using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using Caliburn.Micro;
using OWS.Models;
using OWS.Services;

namespace OWS.ViewModels
{
    public class TabelaObliczoneSlupyViewModel : Screen
    {

        private IDataAccess _data;
        public TabelaObliczoneSlupyViewModel(IDataAccess data)
        {
            _data = data;
        }

        private BindableCollection<ObliczoneSlupy> _tabela;
        public BindableCollection<ObliczoneSlupy> Tabela
        {
            get { return _tabela; }
            set
            {
                _tabela = value;
                NotifyOfPropertyChange(() => Tabela);
            }
        }

        private string _nrProjektu;

        public string NrProjektu
        {
            get { return _nrProjektu; }
            set
            {
                _nrProjektu = value;
                NotifyOfPropertyChange(() => Tabela);
            }
        }

        public async Task ZaladujTabele()
        {
            Tabela = new BindableCollection<ObliczoneSlupy>(await _data.ZaladujTabeleAsync(NrProjektu));
        }

    }
}