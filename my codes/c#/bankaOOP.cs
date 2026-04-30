class Banka
{
    public int Bezny {  get; set; }
    public int Sporici {  get; set; }


    public Banka(int bezny, int sporici)
    {
        Bezny = bezny;
        Sporici = sporici;
    }

    public int ZobrazitZustatekB()
    {
        return Bezny;
    }

    public int ZobrazitZustatekS()
    {
        return Sporici;
    }

    public int Vlozit(int vloz_penize)
    {
        Bezny += vloz_penize;
        return Bezny;
    }

    public int Vyber(int vyber_penez)
    {
        Bezny -= vyber_penez;
        return Bezny;
    }
}
