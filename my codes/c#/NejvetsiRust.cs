using System.Collections;

public class Program
{
    static int Rust(int[] pole)
    {
        int pocet = 1;
        int max = 0;

        for(int i = 0; i < pole.Length - 1; i++)
        {
            
            if (pole[i] < pole[i + 1])
            {
             
                pocet++;
                if(max < pocet)
                {
                    max = pocet;
                }
            }
            if (pole[i] > pole[i + 1])
            {
                pocet = 0;
            }
        }
        return max;
    }
    
    static void Main()
    {
        int[] pole = new int[10];
        for(int i = 0;i < pole.Length;i++)
        {
            Console.WriteLine("Zadej cislo");
            pole[i] = int.Parse(Console.ReadLine());
        }
        int x = Rust(pole);
        Console.WriteLine(x);
       
    }
}
