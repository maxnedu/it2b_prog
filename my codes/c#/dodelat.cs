class Program
{
    static List<int> BezDuplicit(int[] pole)
    {
        int pocet = 0;
        List<int> result = new List<int>();
        for(int i = 0;  i < pole.Length; i++)
        {
            for(int j = 0; j < pole.Length;  j++)
            {
                if (pole[i] == pole[j])
                {
                    pocet++;
                }
            }
            if(pocet < 2)
            {
                result.Add(pole[i]);
            }
            pocet = 0;
        }
        result.Sort();
        return result;

    }

    static void Main()
    {
        int[] pole = { 3, 1, 2, 3, 1 };
        List<int> numbers = BezDuplicit(pole);
        foreach(int i in numbers)
        {
            Console.WriteLine(i);
        }
    }
}
