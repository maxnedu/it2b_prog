class Program
{
    static void Cisla(int[] pole, int[] pole2)
    {
        List<int> ints = new List<int>();
        for(int i = 0; i < pole2.Length; i++)
        {
            if ()
            {
                ints.Add(pole[i]);
            }
        }
        ints.Sort();
        foreach(int i in ints)
        {
            Console.WriteLine(i);
        }
    }



    static void Main()
    {
        int[] pole = { 2, 3, 4};
        int[] pole2 = { 1, 2 };
        Cisla(pole, pole2);
    }
}
