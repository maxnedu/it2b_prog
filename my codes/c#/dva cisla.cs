class Program
{

    static bool StejnaCisla(int[] pole)
    {
        bool stejny = false;
        int i = 0;
        

        while(stejny)
        {
            
            
            if(pole[i] == pole[i + 1])
            {
                return true;
            }
            i++;
            if(i > pole.Length)
            {
                return true;
            }
        }

        
    }
    static void Main()
    {
        int[] pole = { 1, 2, 3, 4, 4, 6};
        bool x = StejnaCisla(pole);
        Console.WriteLine(x);
    }
    
        

}
