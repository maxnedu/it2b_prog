using System.Collections;

public class Program
{
    static int Anomalie(int[] pole)
    {
        int pocet = 0;
        for(int i = 1; i < pole.Length; i++)
        {
            if(i == 9)
            {
                return pocet;
            }
            if (pole[i] < pole[i - 1] && pole[i] < pole[i + 1] || (pole[i] > pole[i - 1] && pole[i] > pole[i + 1])) {
                pocet++;
            }
            
        }
        return pocet;
    }
    
    static void Main()
    {
        int[] pole = new int[10];
        for (int i = 0; i < pole.Length; i++)
        {
            Console.WriteLine("Zadej cislo: ");
            pole[i] = int.Parse(Console.ReadLine());
        }
        int x = Anomalie(pole);
        Console.WriteLine(x);
    }
}
