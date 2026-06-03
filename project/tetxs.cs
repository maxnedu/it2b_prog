public class Texts
{
    private string intro = @"
     ====================================
          WELCOME TO CICHNAMON ARENA
     ====================================

     Here, small creatures solve
     their problems with violence.

     Choose your fighter
     and prove that you are
     the best trainer!
";
    public void TypeIntro()
    {
        foreach(char c in intro)
        {
            Console.Write(c);
            Thread.Sleep(20);
        }
    }
}
