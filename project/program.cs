class Program ()
{
    static void Main()
    {
        Texts texts = new Texts();
        Console.ForegroundColor = ConsoleColor.Red;
        texts.TypeIntro();

        Attack fireball = new Attack("Fireball", 25, "Strong fire attack");
        Attack punch = new Attack("Punch", 10, "Simple basic attack");

        Cichnamon player = new Cichnamon("Warrior", 100, 2, punch, fireball);
        Cichnamon enemy = new Cichnamon("Enemy", 80, 1, punch, fireball);


    }
}
