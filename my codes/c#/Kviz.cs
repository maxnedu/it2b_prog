using System.Collections;

public class Program
{
    
    
    static void Main()
    {
        int body = 0;
        string vstup_uz;
        string[] otazky = { "Jaku barvu ma slunce?", "Jak se nazyva nejmensi jednotka informaci?", "Co znamena zkratka HDD?", "Nejrychlesji typ pameti v PC?", "Koho mate na Hardware?" };
        string[] odpovedy = { "Oranzovou", "Bit", "Hard Drive Disk", "Registry", "Grossmana" };

        for(int i = 0; i <otazky.Length; i++)
        {
            Console.WriteLine(otazky[i]);
            vstup_uz = Console.ReadLine(); 
            if(vstup_uz == odpovedy[i])
            {
                body++;
            }
        }
        Console.WriteLine($"Ziskali jste {body} z 5 bodu");
       
    }
