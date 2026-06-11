public class Texts
{
    private string intro = @"
     ====================================
              POLITMON ARENA
     ====================================

     Welcome to PolitMon Arena!

     Here, famous politicians solve
     their problems in turn-based battles.

     Choose your fighter
     and prove that you are
     the strongest politician!";

    public void TypeIntro()
    {
        foreach(char c in intro)
        {
            Console.Write(c);
            Thread.Sleep(20);
        }
    }
}
