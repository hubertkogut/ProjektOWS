using Caliburn.Micro;
using OWS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OWS.ViewModels
{
    /// <summary>
    /// klasa z logiką widoku TabelaObliczoneSlupyView
    /// </summary>
    public class TabelaObliczoneSlupyViewModel : Screen
    {
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

        /// <summary>
        /// 
        /// </summary>
        public TabelaObliczoneSlupyViewModel()
        {
            DataAccess da = new DataAccess();
            Tabela = new BindableCollection<ObliczoneSlupy>(da.ZaladujTabele());

        }
        }
}
