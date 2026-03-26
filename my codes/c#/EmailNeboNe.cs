class Program
{
    static void Email(string email)
    {
        int pocet = 0;


        foreach (char x in email)
        {
            if (x == '@')
            {
                pocet++;
            }
        }
        if (pocet > 0)
        {
            Console.WriteLine("Je to email");
        }
        else
        {
            Console.WriteLine("Neni to email");
        }
    }

    static void Main()
    {
       
        Email("1234@gmail");

    }
}
