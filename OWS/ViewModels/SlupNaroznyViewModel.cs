using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using Caliburn.Micro;
using OWS.Models;
using OWS.Services;

namespace OWS.ViewModels
{
    public class SlupNaroznyViewModel : Screen, IDataErrorInfo
    {

        private IValidation _valid;
        private IDataAccess _data;

        /// <summary>
        /// konstruktor klasy SlupNaroznyViewModel
        /// </summary>
        ///<values>
        /// ładuje dane z bazy do kolekcji SKlimat za pomocą funkcji ZalSKlimat()
        ///</values>
        public SlupNaroznyViewModel(IValidation valid, IDataAccess data)
        {
            _valid = valid;
            _data = data;

            StrefaKlimatyczna tmp = new StrefaKlimatyczna();
            SKlimat = new BindableCollection<StrefaKlimatyczna>(tmp.ZalSKlimat());
        }


        //ilosc kabli
        /// <summary>
        /// Propercje Ilosc Kabla Głównego
        /// </summary>
        public int IloscKabel1 { get; set; } = 0;
        public int IloscKabel2 { get; set; } = 0;
        public int IloscKabel3 { get; set; } = 0;
        public int IloscKabel4 { get; set; } = 0;
        public int IloscKabel5 { get; set; } = 0;



        /// <summary>
        /// Propercje ilość Kabla Przyłączeniowego
        /// </summary>
        public int IloscPrzylacz1 { get; set; } = 0;
        public int IloscPrzylacz2 { get; set; } = 0;
        public int IloscPrzylacz3 { get; set; } = 0;
        public int IloscPrzylacz4 { get; set; } = 0;
        public int IloscPrzylacz5 { get; set; } = 0;


        /// <summary>
        /// Propercje długość kabla przyłączeniowego
        /// </summary>
        public int DlugoscPrzylacz1 { get; set; } = 0;
        public int DlugoscPrzylacz2 { get; set; } = 0;
        public int DlugoscPrzylacz3 { get; set; } = 0;
        public int DlugoscPrzylacz4 { get; set; } = 0;
        public int DlugoscPrzylacz5 { get; set; } = 0;
        public int DlugoscPrzesla { get; set; } = 0;


        /// <summary>
        /// full property katAlfa
        /// </summary>
        private int _katAlfa;
        public int KatAlfa
        {
            get { return _katAlfa; }
            set
            {
                _katAlfa = value;
                NotifyOfPropertyChange(() => KatAlfa);
            }
        }



        /// <summary>
        /// Implementacja interfejsu IDataErrorInfo dzięki któremu zrealizowana została walidacja danych
        /// wprowadzanych przez użytkownika
        /// </summary>
        string IDataErrorInfo.this[string propertyName]
        {
            get
            {
                string result = null;

                if (propertyName == "IloscKabel1") result = _valid.valKabel(IloscKabel1);
                if (propertyName == "IloscKabel2") result = _valid.valKabel(IloscKabel2);
                if (propertyName == "IloscKabel3") result = _valid.valKabel(IloscKabel3);
                if (propertyName == "IloscKabel4") result = _valid.valKabel(IloscKabel4);
                if (propertyName == "IloscKabel5") result = _valid.valKabel(IloscKabel5);

                if (propertyName == "DlugoscPrzylacz1") result = _valid.valDlugoscPrzylacz(DlugoscPrzylacz1);
                if (propertyName == "DlugoscPrzylacz2") result = _valid.valDlugoscPrzylacz(DlugoscPrzylacz2);
                if (propertyName == "DlugoscPrzylacz3") result = _valid.valDlugoscPrzylacz(DlugoscPrzylacz3);
                if (propertyName == "DlugoscPrzylacz4") result = _valid.valDlugoscPrzylacz(DlugoscPrzylacz4);
                if (propertyName == "DlugoscPrzylacz5") result = _valid.valDlugoscPrzylacz(DlugoscPrzylacz5);

                if (propertyName == "IloscPrzylacz1") result = _valid.valPrzylacz(IloscPrzylacz1);
                if (propertyName == "IloscPrzylacz2") result = _valid.valPrzylacz(IloscPrzylacz2);
                if (propertyName == "IloscPrzylacz3") result = _valid.valPrzylacz(IloscPrzylacz3);
                if (propertyName == "IloscPrzylacz4") result = _valid.valPrzylacz(IloscPrzylacz4);
                if (propertyName == "IloscPrzylacz5") result = _valid.valPrzylacz(IloscPrzylacz5);

                if (propertyName == "DlugoscPrzesla") result = _valid.valDlugoscPrzeslo(DlugoscPrzesla);

                if (propertyName == "NrSlupa") result = _valid.valNrSlupa(NrSlupa);

                if (propertyName == "NrProjektu") result = _valid.valNrProj(NrProjektu);

                if (propertyName == "KatAlfa") result = _valid.valKatAlfa(KatAlfa);

                return result;
            }
        }
        public string Error
        {
            get
            {
                { throw new NotImplementedException(); }
            }
        }








        ///<values>full property Pud, zawiera metode NotifyOfPropertyChange() dynamicznie 
        ///aktualizującą pole Pud
        ///</values>
        private float _pud;
        public float Pud
        {
            get { return _pud; }
            set
            {
                _pud = value;
                NotifyOfPropertyChange(() => Pud);
            }
        }

        ///<values>full property Pp, zawiera metode NotifyOfPropertyChange() dynamicznie 
        ///aktualizującą pole Pp
        ///</values>
        private float _pp;
        public float Pp
        {
            get { return _pp; }
            set
            {
                _pp = value;
                NotifyOfPropertyChange(() => Pp);
            }
        }
        private float _po;
        public float Po
        {
            get { return _po; }
            set
            {
                _po = value;
                NotifyOfPropertyChange(() => Po);
            }
        }

        ///<values>full property Pr, zawiera metode NotifyOfPropertyChange() dynamicznie 
        ///aktualizującą pole Pr
        ///</values>
        private float _pr;
        public float Pr
        {
            get { return _pr; }
            set
            {
                _pr = value;
                NotifyOfPropertyChange(() => Pr);
            }
        }

        ///<values>full property Pu, zawiera metode NotifyOfPropertyChange() dynamicznie 
        ///aktualizującą pole Pu
        ///</values>
        private float _pu;
        public float Pu
        {
            get { return _pu; }
            set
            {
                _pu = value;
                NotifyOfPropertyChange(() => Pu);
            }
        }

        ///<values>full property Wynik, zawiera metode NotifyOfPropertyChange() dynamicznie 
        ///aktualizującą pole Wynik
        ///</values>
        private string _wynik = "----";
        public string Wynik
        {
            get { return _wynik; }
            set
            {
                _wynik = value;
                NotifyOfPropertyChange(() => Wynik);
            }
        }




        ///<values>full property Pud, zawiera metode NotifyOfPropertyChange() dynamicznie 
        ///aktualizującą pole Pud
        ///</values>

        private string _nrSlupa = "-";
        public string NrSlupa
        {
            get { return _nrSlupa; }
            set
            {
                _nrSlupa = value;
                NotifyOfPropertyChange(() => NrSlupa);
            }
        }

        private string _nrProjektu = "-";
        public string NrProjektu
        {
            get { return _nrProjektu; }
            set
            {
                _nrProjektu = value;
                NotifyOfPropertyChange(() => NrProjektu);
            }
        }

        private string _potwierdzenie;

        public string Potwierdzenie
        {
            get { return _potwierdzenie; }
            set
            {
                _potwierdzenie = value;
                NotifyOfPropertyChange(() => Potwierdzenie);
            }
        }


        // wybór stref klimatycznych
        ///<values>Propercja SKlimat, kolekcja typu BindableCollection skłądająca się z obiektów typu StrefaKlimatyczna 
        ///</values>
        public BindableCollection<StrefaKlimatyczna> SKlimat { get; set; }

        ///<values>full property SelectedSWiatrowa, zawiera metode NotifyOfPropertyChange() dynamicznie 
        ///aktualizującą pole SelectedSWiatrowa
        ///</values>
        private StrefaKlimatyczna _selectedSWiatrowa;
        public StrefaKlimatyczna SelectedSWiatrowa
        {
            get { return _selectedSWiatrowa; }
            set
            {
                _selectedSWiatrowa = value;
                NotifyOfPropertyChange(() => SelectedSWiatrowa);
            }
        }

        ///<values>full property SelectedSSadziowa, zawiera metode NotifyOfPropertyChange() dynamicznie 
        ///aktualizującą pole SelectedSSadziowa
        ///</values>
        private StrefaKlimatyczna _selectedSSadziowa;
        public StrefaKlimatyczna SelectedSSadziowa
        {
            get { return _selectedSSadziowa; }
            set
            {
                _selectedSSadziowa = value;
                NotifyOfPropertyChange(() => SelectedSSadziowa);
            }
        }

        //latarnia
        ///<values>Propercja ComboLatarnia, kolekcja typu BindableCollection skłądająca się z obiektów typu ObcLatarnia zawiera metode NotifyOfPropertyChange()
        ///</values>
        private BindableCollection<ObcLatarnia> _comboLatarnia;
        public BindableCollection<ObcLatarnia> ComboLatarnia
        {
            get { return _comboLatarnia; }
            set
            {
                _comboLatarnia = value;
                NotifyOfPropertyChange(() => ComboLatarnia);
            }
        }
        ///<values>full property SelectedComboLatarnia, zawiera metode NotifyOfPropertyChange() dynamicznie 
        ///aktualizującą pole SelectedComboLatarnia
        ///</values>
        private ObcLatarnia _selectedComboLatarnia;
        public ObcLatarnia SelectedComboLatarnia
        {
            get { return _selectedComboLatarnia; }
            set
            {
                _selectedComboLatarnia = value;
                NotifyOfPropertyChange(() => SelectedComboLatarnia);
            }
        }

        ///<values>Propercja ComboSlupy, kolekcja typu BindableCollection skłądająca się z obiektów typu Slupy zawiera metode NotifyOfPropertyChange()
        ///</values>
        private BindableCollection<Slupy> _comboSlupy;
        public BindableCollection<Slupy> ComboSlupy
        {
            get { return _comboSlupy; }
            set
            {
                _comboSlupy = value;
                NotifyOfPropertyChange(() => ComboSlupy);
            }
        }

        ///<values>full property SelectedSlupy, zawiera metode NotifyOfPropertyChange() dynamicznie 
        ///aktualizującą pole SelectedSlupy
        ///</values>
        private Slupy _selectedSlupy;
        public Slupy SelectedSlupy
        {
            get { return _selectedSlupy; }
            set
            {
                _selectedSlupy = value;
                NotifyOfPropertyChange(() => SelectedSlupy);
            }
        }


        ///<values>full property Slupy, zawiera metode NotifyOfPropertyChange() dynamicznie 
        ///aktualizującą pole Slupy
        ///</values>
        private ObliczoneSlupy _slup;
        public ObliczoneSlupy Slup
        {
            get { return _slup; }
            set
            {
                _slup = value;
                NotifyOfPropertyChange(() => Slup);
            }
        }


        ///<summary>Propercje ComboObcKablaWiatremWpPrzelot1 - ComboObcKablaWiatremWpPrzelot5, kolekcja typu BindableCollection 
        ///skłądająca się z obiektów typu ObcKablaWiatremWpPrzelot zawiera metode NotifyOfPropertyChange()
        ///</summary>
        private BindableCollection<ObcKablaWiatremWpPrzelot> _comboObcKablaWiatremWpPrzelot1;
        public BindableCollection<ObcKablaWiatremWpPrzelot> ComboObcKablaWiatremWpPrzelot1
        {
            get { return _comboObcKablaWiatremWpPrzelot1; }
            set
            {
                _comboObcKablaWiatremWpPrzelot1 = value;
                NotifyOfPropertyChange(() => ComboObcKablaWiatremWpPrzelot1);
            }
        }
        private BindableCollection<ObcKablaWiatremWpPrzelot> _comboObcKablaWiatremWpPrzelot2;
        public BindableCollection<ObcKablaWiatremWpPrzelot> ComboObcKablaWiatremWpPrzelot2
        {
            get { return _comboObcKablaWiatremWpPrzelot2; }
            set
            {
                _comboObcKablaWiatremWpPrzelot2 = value;
                NotifyOfPropertyChange(() => ComboObcKablaWiatremWpPrzelot2);
            }
        }
        private BindableCollection<ObcKablaWiatremWpPrzelot> _comboObcKablaWiatremWpPrzelot3;
        public BindableCollection<ObcKablaWiatremWpPrzelot> ComboObcKablaWiatremWpPrzelot3
        {
            get { return _comboObcKablaWiatremWpPrzelot3; }
            set
            {
                _comboObcKablaWiatremWpPrzelot3 = value;
                NotifyOfPropertyChange(() => ComboObcKablaWiatremWpPrzelot3);
            }
        }
        private BindableCollection<ObcKablaWiatremWpPrzelot> _comboObcKablaWiatremWpPrzelot4;
        public BindableCollection<ObcKablaWiatremWpPrzelot> ComboObcKablaWiatremWpPrzelot4
        {
            get { return _comboObcKablaWiatremWpPrzelot4; }
            set
            {
                _comboObcKablaWiatremWpPrzelot4 = value;
                NotifyOfPropertyChange(() => ComboObcKablaWiatremWpPrzelot4);
            }
        }
        private BindableCollection<ObcKablaWiatremWpPrzelot> _comboObcKablaWiatremWpPrzelot5;
        public BindableCollection<ObcKablaWiatremWpPrzelot> ComboObcKablaWiatremWpPrzelot5
        {
            get { return _comboObcKablaWiatremWpPrzelot5; }
            set
            {
                _comboObcKablaWiatremWpPrzelot5 = value;
                NotifyOfPropertyChange(() => ComboObcKablaWiatremWpPrzelot5);
            }
        }

        ///<summary>Propercje SelectedComboObcKablaWiatremWpPrzelot1 - SelectedComboObcKablaWiatremWpPrzelot5,
        ///zawiera metode NotifyOfPropertyChange() dynamicznie 
        ///aktualizującą pole SelectedComboObcKablaWiatremWpPrzelot1-5
        ///</summary>
        private ObcKablaWiatremWpPrzelot _selectedComboObcKablaWiatremWpPrzelot1;
        public ObcKablaWiatremWpPrzelot SelectedComboObcKablaWiatremWpPrzelot1
        {
            get { return _selectedComboObcKablaWiatremWpPrzelot1; }
            set
            {
                _selectedComboObcKablaWiatremWpPrzelot1 = value;
                NotifyOfPropertyChange(() => SelectedComboObcKablaWiatremWpPrzelot1);
            }
        }
        private ObcKablaWiatremWpPrzelot _selectedComboObcKablaWiatremWpPrzelot2;
        public ObcKablaWiatremWpPrzelot SelectedComboObcKablaWiatremWpPrzelot2
        {
            get { return _selectedComboObcKablaWiatremWpPrzelot2; }
            set
            {
                _selectedComboObcKablaWiatremWpPrzelot2 = value;
                NotifyOfPropertyChange(() => SelectedComboObcKablaWiatremWpPrzelot2);
            }
        }
        private ObcKablaWiatremWpPrzelot _selectedComboObcKablaWiatremWpPrzelot3;
        public ObcKablaWiatremWpPrzelot SelectedComboObcKablaWiatremWpPrzelot3
        {
            get { return _selectedComboObcKablaWiatremWpPrzelot3; }
            set
            {
                _selectedComboObcKablaWiatremWpPrzelot3 = value;
                NotifyOfPropertyChange(() => SelectedComboObcKablaWiatremWpPrzelot3);
            }
        }
        private ObcKablaWiatremWpPrzelot _selectedComboObcKablaWiatremWpPrzelot4;
        public ObcKablaWiatremWpPrzelot SelectedComboObcKablaWiatremWpPrzelot4
        {
            get { return _selectedComboObcKablaWiatremWpPrzelot4; }
            set
            {
                _selectedComboObcKablaWiatremWpPrzelot4 = value;
                NotifyOfPropertyChange(() => SelectedComboObcKablaWiatremWpPrzelot4);
            }
        }
        private ObcKablaWiatremWpPrzelot _selectedComboObcKablaWiatremWpPrzelot5;
        public ObcKablaWiatremWpPrzelot SelectedComboObcKablaWiatremWpPrzelot5
        {
            get { return _selectedComboObcKablaWiatremWpPrzelot5; }
            set
            {
                _selectedComboObcKablaWiatremWpPrzelot5 = value;
                NotifyOfPropertyChange(() => SelectedComboObcKablaWiatremWpPrzelot5);
            }
        }

        //COMBO PRZYŁĄCZA
        ///<summary>Propercje ComboObcKablaWiatremWpPrzelot1 - ComboObcKablaWiatremWpPrzelot5, kolekcja typu BindableCollection 
        ///skłądająca się z obiektów typu NaciagPodstawowy zawiera metode NotifyOfPropertyChange()
        ///</summary>
        private BindableCollection<NaciagPodstawowy> _comboPrzylaczPrzelot1;
        public BindableCollection<NaciagPodstawowy> ComboPrzylaczPrzelot1
        {
            get { return _comboPrzylaczPrzelot1; }
            set
            {
                _comboPrzylaczPrzelot1 = value;
                NotifyOfPropertyChange(() => ComboPrzylaczPrzelot1);
            }
        }
        private BindableCollection<NaciagPodstawowy> _comboPrzylaczPrzelot2;
        public BindableCollection<NaciagPodstawowy> ComboPrzylaczPrzelot2
        {
            get { return _comboPrzylaczPrzelot2; }
            set
            {
                _comboPrzylaczPrzelot2 = value;
                NotifyOfPropertyChange(() => ComboPrzylaczPrzelot2);
            }
        }
        private BindableCollection<NaciagPodstawowy> _comboPrzylaczPrzelot3;
        public BindableCollection<NaciagPodstawowy> ComboPrzylaczPrzelot3
        {
            get { return _comboPrzylaczPrzelot3; }
            set
            {
                _comboPrzylaczPrzelot3 = value;
                NotifyOfPropertyChange(() => ComboPrzylaczPrzelot3);
            }
        }
        private BindableCollection<NaciagPodstawowy> _comboPrzylaczPrzelot4;
        public BindableCollection<NaciagPodstawowy> ComboPrzylaczPrzelot4
        {
            get { return _comboPrzylaczPrzelot4; }
            set
            {
                _comboPrzylaczPrzelot4 = value;
                NotifyOfPropertyChange(() => ComboPrzylaczPrzelot4);
            }
        }
        private BindableCollection<NaciagPodstawowy> _comboPrzylaczPrzelot5;
        public BindableCollection<NaciagPodstawowy> ComboPrzylaczPrzelot5
        {
            get { return _comboPrzylaczPrzelot5; }
            set
            {
                _comboPrzylaczPrzelot5 = value;
                NotifyOfPropertyChange(() => ComboPrzylaczPrzelot5);
            }
        }

        ///<summary>Propercje SelectedComboPrzylacz1 - SelectedComboPrzylacz5,
        ///zawiera metode NotifyOfPropertyChange() dynamicznie 
        ///aktualizującą pole SelectedComboPrzylacz1-5
        ///</summary>
        private NaciagPodstawowy _selectedComboPrzylaczPrzelot1;
        public NaciagPodstawowy SelectedComboPrzylaczPrzelot1
        {
            get { return _selectedComboPrzylaczPrzelot1; }
            set
            {
                _selectedComboPrzylaczPrzelot1 = value;
                NotifyOfPropertyChange(() => SelectedComboPrzylaczPrzelot1);
            }
        }
        private NaciagPodstawowy _selectedComboPrzylaczPrzelot2;
        public NaciagPodstawowy SelectedComboPrzylaczPrzelot2
        {
            get { return _selectedComboPrzylaczPrzelot2; }
            set
            {
                _selectedComboPrzylaczPrzelot2 = value;
                NotifyOfPropertyChange(() => SelectedComboPrzylaczPrzelot2);
            }
        }
        private NaciagPodstawowy _selectedComboPrzylaczPrzelot3;
        public NaciagPodstawowy SelectedComboPrzylaczPrzelot3
        {
            get { return _selectedComboPrzylaczPrzelot3; }
            set
            {
                _selectedComboPrzylaczPrzelot3 = value;
                NotifyOfPropertyChange(() => SelectedComboPrzylaczPrzelot3);
            }
        }
        private NaciagPodstawowy _selectedComboPrzylaczPrzelot4;
        public NaciagPodstawowy SelectedComboPrzylaczPrzelot4
        {
            get { return _selectedComboPrzylaczPrzelot4; }
            set
            {
                _selectedComboPrzylaczPrzelot4 = value;
                NotifyOfPropertyChange(() => SelectedComboPrzylaczPrzelot4);
            }
        }
        private NaciagPodstawowy _selectedComboPrzylaczPrzelot5;

        public NaciagPodstawowy SelectedComboPrzylaczPrzelot5
        {
            get { return _selectedComboPrzylaczPrzelot5; }
            set
            {
                _selectedComboPrzylaczPrzelot5 = value;
                NotifyOfPropertyChange(() => SelectedComboPrzylaczPrzelot5);
            }
        }

        /// <summary>
        /// Metoda powiązana z przyciskiem Zapisz Klasy SlupNaroznyView, wysyła informacje o obliczonym słupie
        /// do bazy danych, posiada również asynchroniczne opóżnienie odpowiedzialene za zamianę propercji
        /// Potwierdzenie, informującej o poprawnym zapisie
        /// </summary>
        public async void Zapisz()
        {
            _data.ZapiszSlupa(NrSlupa, Wynik, Pu, Pud, TypSlupa, NrProjektu);
            Potwierdzenie = "Poprawnie zapisano wynik";
            await Task.Delay(4000);
            Potwierdzenie = "";
        }

        public string TypSlupa { get; } = "S. narożny";
        

        //przycisk załaduj dane
        /// <summary>
        /// metoda ZaladujDane- powiązana z przyciskiem w pliku SlupNarożnyView, za pomocą metod z klasy DataAcces
        /// metoda ZaladujSlupy ładuje dane do kolekcji zdefiniowanych w klasie SlupNarożnyViewModel
        /// </summary>
        public async Task ZaladujDane()
        {
           
            var listO = await _data.ZaladujKabelGlownyPrzelotAsync(SelectedSWiatrowa.StrefaWiatrowa);
            var listP = await _data.ZaladujNaciagPodstawowyAsync();

            ComboObcKablaWiatremWpPrzelot1 = new BindableCollection<ObcKablaWiatremWpPrzelot>(listO);
            ComboObcKablaWiatremWpPrzelot2 = new BindableCollection<ObcKablaWiatremWpPrzelot>(listO);
            ComboObcKablaWiatremWpPrzelot3 = new BindableCollection<ObcKablaWiatremWpPrzelot>(listO);
            ComboObcKablaWiatremWpPrzelot4 = new BindableCollection<ObcKablaWiatremWpPrzelot>(listO);
            ComboObcKablaWiatremWpPrzelot5 = new BindableCollection<ObcKablaWiatremWpPrzelot>(listO);
            ComboPrzylaczPrzelot1 = new BindableCollection<NaciagPodstawowy>(listP);
            ComboPrzylaczPrzelot2 = new BindableCollection<NaciagPodstawowy>(listP);
            ComboPrzylaczPrzelot3 = new BindableCollection<NaciagPodstawowy>(listP);
            ComboPrzylaczPrzelot4 = new BindableCollection<NaciagPodstawowy>(listP);
            ComboPrzylaczPrzelot5 = new BindableCollection<NaciagPodstawowy>(listP);
            ComboLatarnia = new BindableCollection<ObcLatarnia>(await _data.ZaladujLatarniaAsync(SelectedSWiatrowa.StrefaWiatrowa));
            ComboSlupy = new BindableCollection<Slupy>( await _data.ZaladujSlupyNarozneAsync());
        }


        // przycik oblicz
        /// <summary>
        /// Oblicza PP, Po, Pr, Pu oraz Wynik na podstawie danych wybranych przez użytkownika 
        /// </summary>
        public void ObliczNarozny()
        {
            if (SelectedSWiatrowa.StrefaWiatrowa == "W1") Pud = SelectedSlupy.WytrzymaloscW1;
            else Pud = SelectedSlupy.WytrzymaloscW2;
            Pp = DlugoscPrzesla * (IloscKabel1 * SelectedComboObcKablaWiatremWpPrzelot1.ObciazenieWp + IloscKabel2 * SelectedComboObcKablaWiatremWpPrzelot2.ObciazenieWp
                + IloscKabel3 * SelectedComboObcKablaWiatremWpPrzelot3.ObciazenieWp + IloscKabel4 * SelectedComboObcKablaWiatremWpPrzelot4.ObciazenieWp
                + IloscKabel5 * SelectedComboObcKablaWiatremWpPrzelot5.ObciazenieWp);
            Po = SelectedComboLatarnia.ObciazeniePo;

            Pr = IloscPrzylacz1 * NaciagPodstawowy.Naciag(DlugoscPrzylacz1, SelectedComboPrzylaczPrzelot1)
                         + IloscPrzylacz2 * NaciagPodstawowy.Naciag(DlugoscPrzylacz2, SelectedComboPrzylaczPrzelot2)
                + IloscPrzylacz3 * NaciagPodstawowy.Naciag(DlugoscPrzylacz3, SelectedComboPrzylaczPrzelot3)
                         + IloscPrzylacz4 * NaciagPodstawowy.Naciag(DlugoscPrzylacz4, SelectedComboPrzylaczPrzelot4)
                + IloscPrzylacz5 * NaciagPodstawowy.Naciag(DlugoscPrzylacz5, SelectedComboPrzylaczPrzelot5);

            double b = Math.Cos((KatAlfa / 2) * Math.PI / 180);
            Pu = (float)Math.Round(2 * Pp * b + Po + Pr, 2);

            if (Pud >= Pu) Wynik = "Słup spełnia warunek";
            else if (Pud < Pu) Wynik = "Słup nie spełnia warunku";
        }
    }
}
