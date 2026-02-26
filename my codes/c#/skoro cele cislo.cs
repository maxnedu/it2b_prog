class Program
{
    static bool Cislo(double cislo, double odchylka)
    {
        double dec = cislo + odchylka;
        int cele = (int) Math.Round(cislo, 1);

        if(cislo == dec - odchylka)
        {
            return true;
        }else
        {
            return false;
        }
    }


    static void Main()
    {
       bool x = Cislo(1.01, 0.01);
        Console.Write(x);
    }
}
