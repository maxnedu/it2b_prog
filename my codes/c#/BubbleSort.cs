class Program
{
    static void Main()
    {
     
        List<int> list = new List<int>() {18, 8, 5, 24, 0, 6 };
        
        for(int i  = 0; i < list.Count; i++)
        {
            for(int j = 0; j < list.Count - i - 1; j++)
            {
                if (list[j] > list[j + 1])
                {
                    int x = list[j];
                    list[j] = list[j + 1];
                    list[j + 1] = x;
                }
            }
        }
        for(int g = 0; g < list.Count; g++)
        {
            Console.WriteLine(list[g]);
        }
    }
}
