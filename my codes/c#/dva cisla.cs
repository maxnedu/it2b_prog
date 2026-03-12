class Program
{
    static bool StejnaCisla(double[] pole)
    {
        for(int i = 0; i < pole.Length; i++)
        {
            if(pole[i] == pole[i + 1])
            {
                return true;
            }
        }

        
        return false;
    }

    static void Main()
    {
        double[] pole = new double[10];

        for(int i = 0; i < pole.Length;i++)
        {
            Console.WriteLine("Write first number: ");
            pole[i] = double.Parse(Console.ReadLine());
        }

        bool Jestejny = StejnaCisla(pole);

        if(Jestejny)
        {
            Console.WriteLine(Jestejny);
        }else
        {
            Console.WriteLine(!Jestejny);
        }
    }
}
    
        

}
