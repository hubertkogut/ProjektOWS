using System.Collections.Generic;
using System.Threading.Tasks;
using OWS.Models;

namespace OWS.Services
{
    public interface IDataAccess
    {
        /// <summary>
        /// Pobiera dane z tabeli ObliczoneSlupy
        /// </summary>
        /// <returns></returns>
        Task<List<ObliczoneSlupy>> ZaladujTabeleAsync(string nrProjektu);

        /// <summary>
        /// Pobiera dane z tabeli Slupy
        /// </summary>
        /// <returns></returns>
        Task<List<Slupy>> ZaladujSlupyAsync();

        /// <summary>
        /// Pobiera dane z tabeli SlupyNarozne
        /// </summary>
        /// <returns></returns>
        Task<List<Slupy>> ZaladujSlupyNarozneAsync();

        /// <summary>
        /// Pobiera dane z tabeli ObcLatarnia
        /// </summary>
        /// <param name="SelectedWiatr"></param>
        /// <returns></returns>
        Task<List<ObcLatarnia>> ZaladujLatarniaAsync(string SelectedWiatr);

        /// <summary>
        /// Pobiera dane z tabeli NaciagPodstawowy
        /// </summary>
        /// <returns></returns>
        Task<List<NaciagPodstawowy>> ZaladujNaciagPodstawowyAsync();

        /// <summary>
        /// Pobiera dane z tabeli ObcKablaWiatremWpPrzelot
        /// </summary>
        /// <param name="SelectedWiatr"></param>
        /// <returns></returns>
        Task<List<ObcKablaWiatremWpPrzelot>> ZaladujKabelGlownyPrzelotAsync(string SelectedWiatr);

        /// <summary>
        /// Metoda zapisuje do bazy informację o obliczonym słupie
        /// </summary>
        /// <param name="NrSlupa"></param>
        /// <param name="Wynik"></param>
        /// <param name="Pu"></param>
        /// <param name="Pud"></param>
        void ZapiszSlupa(string NrSlupa, string Wynik, float Pu, float Pud, string TypSlupa, string NrProjektu);

    }
}