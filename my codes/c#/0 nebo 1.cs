class Program
{
    static bool Cislo(int cislo)
    {
        bool x = cislo % 10 == 0 || cislo % 10 == 1;

        while (cislo > 0)
        {
            cislo = cislo / 10;
            if (cislo % 10 != 0 && cislo % 10 != 1)
            {
                x = false;
            }
        }
        
        return x;
    }


    static void Main()
    {
       bool x = Cislo(101211);
        Console.Write(x);
    }
}
