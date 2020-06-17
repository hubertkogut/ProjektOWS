namespace OWS.Services
{
    public interface IValidation
    {
        string valKabel(int iloscKabel);
        string valPrzylacz(int iloscPrzylacz);
        string valDlugoscPrzylacz(int dlugosc);
        string valDlugoscPrzeslo(int dlugosc);
        string valNrSlupa(string nr);
        string valKatAlfa(int kat);
        string valNrProj(string nr);
    }
}