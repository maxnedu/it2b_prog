class Program
{
    static void Main ()
    {
        double[] pole = new double[10];

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Napis cislo ");
            pole[i] = double.Parse(Console.ReadLine());
        }
        double max = pole.Max();
        double min = pole.Min();

        Console.WriteLine("Maximum je:" + max);
        Console.WriteLine("Rozdil min a max:" + (max - min));

        Array.Sort(pole);

        double median = (pole[4] + pole[5]) / 2;

        Console.WriteLine("Nejmensi cisla jsou:" + pole[0] + ", " + pole[1] + ", " + pole[2]);
        Console.WriteLine("Median je:" + median);


    }
}
