
class Program
{
    static void Email(string email)
    {
        int pocet = 0;


        for(int i = 0; i < email.Length - 1; i++)
        {
            if(email[i] == '@' && email[i + 1] == '.' )
            {
                pocet++;
            }
        } if ( pocet > 0 )
        {
            Console.WriteLine("Je to email");
        } else
        {
            Console.WriteLine("Neni to email");
        }
        
    }

    static void Main()
    {
       
        Email("maxndu@.gmail");

    }
}
