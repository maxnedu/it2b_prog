class Banka
{
    public int Bezny { get; set; }
    public int Sporici { get; set; }
    private string Heslo { get; set; }


    public Banka(int bezny, int sporici, string heslo)
    {
        Bezny = bezny;
        Sporici = sporici;
        Heslo = heslo;
    }
    
    public bool Autorizace(string heslo)
    {
        if(heslo != Heslo)
        {
            return false;
        } else
        {
            return true;
        }
    }
    public int ZobrazitZustatekB()
    {
        return Bezny;
    }

    public int ZobrazitZustatekS()
    {
        return Sporici;
    }

    public int Vlozit(int vloz_penize = 234)
    {
        Bezny += vloz_penize;
        return Bezny;
    }

    public int Vyber(int vyber_penez = 100)
    {
        Bezny -= vyber_penez;
        return Bezny;
    }
}
