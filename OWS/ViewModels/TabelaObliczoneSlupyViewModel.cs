using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using Caliburn.Micro;
using OWS.Models;
using OWS.Services;

namespace OWS.ViewModels
{
    /// <summary>
    /// klasa z logiką widoku TabelaObliczoneSlupyView
    /// </summary>
    public class TabelaObliczoneSlupyViewModel : Screen
    {

        private IDataAccess _data;

        ///<values>Propercja Tabela, kolekcja typu BindableCollection skłądająca się z obiektów typu ObliczoneSlupy zawiera metode NotifyOfPropertyChange()
        ///</values>
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





        public TabelaObliczoneSlupyViewModel(IDataAccess data)
        { 
            _data = data;
        }
        
        public async Task ZaladujTabele()
        {
            Tabela = new BindableCollection<ObliczoneSlupy>(await _data.ZaladujTabeleAsync(NrProjektu));
        }

    }
}