using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Caliburn.Micro;
using OWS.Models;

namespace OWS.ViewModels
{
    public class SlupPrzelotowyViewModel : Screen, IDataErrorInfo
    {
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

        public string TypSlupa { get; } = "Słup przelotowy";



        /// <summary>
        /// Implementacja interfejsu IDataErrorInfo dzięki któremu zrealizowana została walidacja danych
        /// wprowadzanych przez użytkownika
        /// </summary>
        string IDataErrorInfo.this[string propertyName]
        {
            get
            {
                string result = null;

                if (propertyName == "IloscKabel1") result = Validation.valKabel(IloscKabel1);
                if (propertyName == "IloscKabel2") result = Validation.valKabel(IloscKabel2);
                if (propertyName == "IloscKabel3") result = Validation.valKabel(IloscKabel3);
                if (propertyName == "IloscKabel4") result = Validation.valKabel(IloscKabel4);
                if (propertyName == "IloscKabel5") result = Validation.valKabel(IloscKabel5);

                if (propertyName == "DlugoscPrzylacz1") result = Validation.valDlugoscPrzylacz(DlugoscPrzylacz1);
                if (propertyName == "DlugoscPrzylacz2") result = Validation.valDlugoscPrzylacz(DlugoscPrzylacz2);
                if (propertyName == "DlugoscPrzylacz3") result = Validation.valDlugoscPrzylacz(DlugoscPrzylacz3);
                if (propertyName == "DlugoscPrzylacz4") result = Validation.valDlugoscPrzylacz(DlugoscPrzylacz4);
                if (propertyName == "DlugoscPrzylacz5") result = Validation.valDlugoscPrzylacz(DlugoscPrzylacz5);

                if (propertyName == "IloscPrzylacz1") result = Validation.valPrzylacz(IloscPrzylacz1);
                if (propertyName == "IloscPrzylacz2") result = Validation.valPrzylacz(IloscPrzylacz2);
                if (propertyName == "IloscPrzylacz3") result = Validation.valPrzylacz(IloscPrzylacz3);
                if (propertyName == "IloscPrzylacz4") result = Validation.valPrzylacz(IloscPrzylacz4);
                if (propertyName == "IloscPrzylacz5") result = Validation.valPrzylacz(IloscPrzylacz5);

                if (propertyName == "DlugoscPrzesla") result = Validation.valDlugoscPrzeslo(DlugoscPrzesla);

                if (propertyName == "NrSlupa") result = Validation.valNrSlupa(NrSlupa);

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
            DataAccess da = new DataAccess();
            da.ZapiszSlupa(NrSlupa, Wynik, Pu, Pud, TypSlupa);
            Potwierdzenie = "Poprawnie zapisano wynik";
            await Task.Delay(4000);
            Potwierdzenie = "";
        }


        /// <summary>
        /// konstruktor klasy SlupPrzelotowyViewModel
        /// </summary>
        ///<values>
        /// ładuje dane z bazy do kolekcji SKlimat za pomocą funkcji ZalSKlimat()
        ///</values>
        public SlupPrzelotowyViewModel()
        {
            StrefaKlimatyczna tmp = new StrefaKlimatyczna();
            SKlimat = new BindableCollection<StrefaKlimatyczna>(tmp.ZalSKlimat());
        }


        //przycisk załaduj dane
        /// <summary>
        /// metoda ZaladujDane- powiązana z przyciskiem w pliku SlupPrzelotowyView, za pomocą metod z klasy DataAcces
        /// metoda ZaladujSlupy ładuje dane do kolekcji zdefiniowanych w klasie SlupPrzelotowyViewModel
        /// </summary>
        public void ZaladujDane()
        {

            DataAccess da = new DataAccess();
            ComboObcKablaWiatremWpPrzelot1 = new BindableCollection<ObcKablaWiatremWpPrzelot>(da.ZaladujKabelGlownyPrzelot(SelectedSWiatrowa.StrefaWiatrowa));
            ComboObcKablaWiatremWpPrzelot2 = new BindableCollection<ObcKablaWiatremWpPrzelot>(da.ZaladujKabelGlownyPrzelot(SelectedSWiatrowa.StrefaWiatrowa));
            ComboObcKablaWiatremWpPrzelot3 = new BindableCollection<ObcKablaWiatremWpPrzelot>(da.ZaladujKabelGlownyPrzelot(SelectedSWiatrowa.StrefaWiatrowa));
            ComboObcKablaWiatremWpPrzelot4 = new BindableCollection<ObcKablaWiatremWpPrzelot>(da.ZaladujKabelGlownyPrzelot(SelectedSWiatrowa.StrefaWiatrowa));
            ComboObcKablaWiatremWpPrzelot5 = new BindableCollection<ObcKablaWiatremWpPrzelot>(da.ZaladujKabelGlownyPrzelot(SelectedSWiatrowa.StrefaWiatrowa));
            ComboPrzylaczPrzelot1 = new BindableCollection<NaciagPodstawowy>(da.ZaladujNaciagPodstawowy());
            ComboPrzylaczPrzelot2 = new BindableCollection<NaciagPodstawowy>(da.ZaladujNaciagPodstawowy());
            ComboPrzylaczPrzelot3 = new BindableCollection<NaciagPodstawowy>(da.ZaladujNaciagPodstawowy());
            ComboPrzylaczPrzelot4 = new BindableCollection<NaciagPodstawowy>(da.ZaladujNaciagPodstawowy());
            ComboPrzylaczPrzelot5 = new BindableCollection<NaciagPodstawowy>(da.ZaladujNaciagPodstawowy());
            ComboLatarnia = new BindableCollection<ObcLatarnia>(da.ZaladujLatarnia(SelectedSWiatrowa.StrefaWiatrowa));
            ComboSlupy = new BindableCollection<Slupy>(da.ZaladujSlupy());

        }


        // przycik oblicz
        /// <summary>
        /// Oblicza PP, Po, Pr, Pu oraz Wynik na podstawie danych wybranych przez użytkownika 
        /// </summary>
        public void ObliczPrzelotowy()
        {
            if (SelectedSWiatrowa.StrefaWiatrowa == "W1") Pud = SelectedSlupy.WytrzymaloscW1;
            else Pud = SelectedSlupy.WytrzymaloscW2;
            Pp = DlugoscPrzesla * (IloscKabel1 * SelectedComboObcKablaWiatremWpPrzelot1.ObciazenieWp + IloscKabel2 * SelectedComboObcKablaWiatremWpPrzelot2.ObciazenieWp + IloscKabel3 * SelectedComboObcKablaWiatremWpPrzelot3.ObciazenieWp +
                IloscKabel4 * SelectedComboObcKablaWiatremWpPrzelot4.ObciazenieWp + IloscKabel5 * SelectedComboObcKablaWiatremWpPrzelot5.ObciazenieWp);
            Po = SelectedComboLatarnia.ObciazeniePo;

            Pr = 0.2F * (IloscPrzylacz1 * NaciagPodstawowy.Naciag(DlugoscPrzylacz1, SelectedComboPrzylaczPrzelot1) + IloscPrzylacz2 * NaciagPodstawowy.Naciag(DlugoscPrzylacz2, SelectedComboPrzylaczPrzelot2)
                + IloscPrzylacz3 * NaciagPodstawowy.Naciag(DlugoscPrzylacz3, SelectedComboPrzylaczPrzelot3) + IloscPrzylacz4 * NaciagPodstawowy.Naciag(DlugoscPrzylacz4, SelectedComboPrzylaczPrzelot4)
                + IloscPrzylacz5 * NaciagPodstawowy.Naciag(DlugoscPrzylacz5, SelectedComboPrzylaczPrzelot5));

            Pu = Pp + Po + Pr;
            if (Pud >= Pu) Wynik = "Słup spełnia warunek";
            else if (Pud < Pu) Wynik = "Słup nie spełnia warunku";


        }

    }
}
