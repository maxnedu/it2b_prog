using System.Collections;

public class Program
{
    
    
    static void Main()
    {
        Console.WriteLine("Zadej mi slovo");
        string slovo = Console.ReadLine();

        Console.WriteLine("Zadej znak");
        char cenzura = Console.ReadLine()[0];

        Console.WriteLine("Cenzurovane slovo je: ");
        foreach(char znak in slovo)
        {
            if(znak == cenzura)
            {
                Console.WriteLine("*");
            }else
            {
                Console.WriteLine(znak);    
            }
        }

        
        
        
    }
    
}
