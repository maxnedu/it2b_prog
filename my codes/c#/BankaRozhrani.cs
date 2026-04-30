class Program
{
   static void Main()
    {
        bool pokracovat = true;
        int vyber;
        Banka banka = new Banka(10000, 2000);
        
        while (pokracovat)
        {
            Console.WriteLine("Vyber operace:");
            Console.WriteLine("1) Zobrazit zustatek na beznem uctu");
            Console.WriteLine("2) Zobrazit zustatek na sporicim uctu");
            Console.WriteLine("3) Vlozit penize");
            Console.WriteLine("4) Vyber penez");
            Console.WriteLine("5) Ukoncit program");
            vyber = int.Parse(Console.ReadLine());

            switch (vyber)
            {
                case 1:
                    Console.WriteLine(banka.ZobrazitZustatekB());
                    break;
                case 2: 
                    Console.WriteLine(banka.ZobrazitZustatekS());
                    break;
                case 3:
                    Console.WriteLine("Kolik chcete vlozit?");
                    int vloz = int.Parse(Console.ReadLine());
                    banka.Vlozit(vloz);
                    break;
                case 4:
                    Console.WriteLine("Kolik chcete vybrat?");
                    int vybrat = int.Parse(Console.ReadLine());
                    banka.Vyber(vybrat);
                    break;
                case 5:
                    pokracovat = false;
                    break;
                default:
                    Console.WriteLine("Spatny vstup");
                    break;
            }
        }
    }
}
