class Program
{

    static void Main()
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Zadej pocet cisel: ");
        int pocet = int.Parse(Console.ReadLine());

        for(int i = 0; i < pocet; i++)
        {
            Console.WriteLine("Zadej cislo: ");
            int cislo = int.Parse(Console.ReadLine());
            numbers.Add(cislo);
        }
        Console.WriteLine("Zadej hodnotu kteru chces smazat");
        int hodnota = int.Parse(Console.ReadLine());

        for(int j = 0; j < numbers.Count; j++)
        {
            if(numbers[j] == hodnota)
            {
                numbers.RemoveAt(j);
                j--;
            }
        }
        Console.WriteLine("Novy list: ");
        foreach(int y in numbers)
        {
            Console.WriteLine(y);
        }


    }
}
