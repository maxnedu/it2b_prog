class Program
{

    static void Main()
    {
        char znak;
        string nazev;
        List<string> filmy = new List<string>() { "Forrest Gump", "Harry Potter a Kamen mudrcu", "Matrix" };
        List<double> hodnoceni = new List<double>() {0.97, 0.80, 0.9 };

        Console.WriteLine("Aktualni filmy a jejich hodnoceni");
        for (int i = 0; i < filmy.Count; i++)
        {
            Console.WriteLine($"{filmy[i]} a {hodnoceni[i] * 100}%");
        }
        Console.WriteLine("Vyber operace: ");
        znak = char.Parse(Console.ReadLine());
        if (znak == 'a')
        {
            Console.WriteLine("Zadej nazev filmu ");
            nazev = Console.ReadLine();
            filmy.Add(nazev);
        }
        


    }
}
