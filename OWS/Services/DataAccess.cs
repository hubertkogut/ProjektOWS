using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using OWS.ViewModels;
using System.Windows.Input;
using OWS.Models;
using System.Configuration;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;

namespace OWS.Services
{
    /// <summary>
    ///  Klasa odpowiedzialna za pobieranie danych z bazy
    /// </summary>
    public class DataAccess : IDataAccess
    {
        /// <summary>
        /// Pobiera dane z tabeli ObliczoneSlupy
        /// </summary>
        /// <returns></returns>
        public async Task<List<ObliczoneSlupy>> ZaladujTabeleAsync(string nrProjektu)
        {

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BazaOWS")))
            {
                if (nrProjektu == null)
                {
                    var output = await connection.QueryAsync<ObliczoneSlupy>(
                        $"select * from ObliczoneSlupy").ConfigureAwait(false);

                    return output.ToList();
                }
                else
                {
                    var output = await connection.QueryAsync<ObliczoneSlupy>(
                        $"select * from ObliczoneSlupy where NrProjektu = '{nrProjektu}'").ConfigureAwait(false);

                    return output.ToList();
                }
            }
        }

        /// <summary>
        /// Pobiera dane z tabeli Slupy
        /// </summary>
        /// <returns></returns>
        public async Task<List<Slupy>> ZaladujSlupyAsync()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BazaOWS")))
            {
                var output = await connection.QueryAsync<Slupy>(
                $"select * from Slupy");
                return output.ToList();
            }
        }

        /// <summary>
        /// Pobiera dane z tabeli SlupyNarozne
        /// </summary>
        /// <returns></returns>
        public async Task<List<Slupy>> ZaladujSlupyNarozneAsync()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BazaOWS")))
            {
                var output = await connection.QueryAsync<Slupy>(
                    $"select * from SlupyNarozne");
                return output.ToList();
            }
        }


        /// <summary>
        /// Pobiera dane z tabeli ObcLatarnia
        /// </summary>
        /// <param name="SelectedWiatr"></param>
        /// <returns></returns>
        public async Task<List<ObcLatarnia>> ZaladujLatarniaAsync(string SelectedWiatr)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BazaOWS")))
            {
                var output = await connection.QueryAsync<ObcLatarnia>(
                $"select * from ObcLatarnia where StrefaWiatrowa = '{SelectedWiatr}'");
                return output.ToList();
            }
        }

        /// <summary>
        /// Pobiera dane z tabeli NaciagPodstawowy
        /// </summary>
        /// <returns></returns>
        public async Task<List<NaciagPodstawowy>> ZaladujNaciagPodstawowyAsync()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BazaOWS")))
            {
                var output = await connection.QueryAsync<NaciagPodstawowy>(
                $"select * from NaciagPodstawowy ");
                return output.ToList();
            }
        }

        /// <summary>
        /// Pobiera dane z tabeli ObcKablaWiatremWpPrzelot
        /// </summary>
        /// <param name="SelectedWiatr"></param>
        /// <returns></returns>
        public async Task<List<ObcKablaWiatremWpPrzelot>> ZaladujKabelGlownyPrzelotAsync(string SelectedWiatr)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BazaOWS")))
            {
                var output = await connection.QueryAsync<ObcKablaWiatremWpPrzelot>(
                $"select * from ObcKablaWiatremWpPrzelot where StrefaWiatrowa = '{SelectedWiatr}'");
                return output.ToList();
            }
        }


        /// <summary>
        /// Metoda zapisuje do bazy informację o obliczonym słupie
        /// </summary>
        /// <param name="NrSlupa"></param>
        /// <param name="Wynik"></param>
        /// <param name="Pu"></param>
        /// <param name="Pud"></param>
        public void ZapiszSlupa(string NrSlupa, string Wynik, float Pu, float Pud, string TypSlupa, string NrProjektu)
        {

            SqlConnection con = new SqlConnection
            {
                ConnectionString = ConfigurationManager.ConnectionStrings["BazaOWS"].ConnectionString
            };
            con.Open();
            SqlCommand cmd = new SqlCommand
            {
                CommandText = "Insert into ObliczoneSlupy(NrSlupa, Wynik, Pu, Pud, TypSlupa, NrProjektu) values (@NrSlupa, @Wynik, @Pu, @Pud, @TypSlupa, @NrProjektu)",
                Connection = con
            };
            cmd.Parameters.AddWithValue("@NrSlupa", NrSlupa);
            cmd.Parameters.AddWithValue("@Wynik", Wynik);
            cmd.Parameters.AddWithValue("@Pu", Pu);
            cmd.Parameters.AddWithValue("@Pud", Pud);
            cmd.Parameters.AddWithValue("@TypSlupa", TypSlupa);
            cmd.Parameters.AddWithValue("@NrProjektu", NrProjektu);
            cmd.Connection = con;
            int a = cmd.ExecuteNonQuery();
        }

       
    }
}
