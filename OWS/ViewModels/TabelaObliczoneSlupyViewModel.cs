using Caliburn.Micro;
using OWS.Models;

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
        /// Konstruktor klasy TabelaObliczoneSlupyViewModel wczytujący obliczone słupy z bazy danych
        /// </summary>
        public TabelaObliczoneSlupyViewModel()
        {
            DataAccess da = new DataAccess();
            Tabela = new BindableCollection<ObliczoneSlupy>(da.ZaladujTabele());

        }
    }
}