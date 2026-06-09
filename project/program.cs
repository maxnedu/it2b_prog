using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        Texts texts = new Texts();
        Console.ForegroundColor = ConsoleColor.Red;
        texts.TypeIntro();
        Console.ResetColor();

        Attack speech = new Attack("Long Speech", 10, "A long political speech.");
        Attack sanctions = new Attack("Sanctions", 25, "Economic pressure attack.");

        Attack droneSpeech = new Attack("Motivational Speech", 12, "Raises morale and attacks the opponent.");
        Attack droneStrike = new Attack("Drone Strike", 28, "A precise tactical attack.");

        Attack propaganda = new Attack("Propaganda", 14, "Confuses the opponent.");
        Attack gasPressure = new Attack("Gas Pressure", 24, "Uses energy pressure.");

        Attack populism = new Attack("Populism", 15, "A loud populist attack.");
        Attack antiImmigration = new Attack("Mass Deportation", 23, "Promises to deport illegal immigrants.");

        Coach playerCoach = new Coach("Player");
        Coach enemyCoach = new Coach("Computer");

        PolitMon trump = new PolitMon("Donald Trump", 100, 3, speech, sanctions);
        PolitMon zelensky = new PolitMon("Volodymyr Zelensky", 90, 4, droneSpeech, droneStrike);
        PolitMon putin = new PolitMon("Vladimir Putin", 110, 2, propaganda, gasPressure);
        PolitMon okamura = new PolitMon("Tomio Okamura", 85, 5, populism, antiImmigration);

        playerCoach.AddPolitMon(trump);
        playerCoach.AddPolitMon(zelensky);
        playerCoach.AddPolitMon(putin);
        playerCoach.AddPolitMon(okamura);

        Console.WriteLine("Choose your PolitMon:");
        Console.WriteLine("1 - Donald Trump");
        Console.WriteLine("2 - Volodymyr Zelensky");
        Console.WriteLine("3 - Vladimir Putin");
        Console.WriteLine("4 - Tomio Okamura");

        string choice = Console.ReadLine();

        if (choice == "1")
        {
            playerCoach.SelectPolitMon(0);
        }
        else if (choice == "2")
        {
            playerCoach.SelectPolitMon(1);
        }
        else if (choice == "3")
        {
            playerCoach.SelectPolitMon(2);
        }
        else
        {
            playerCoach.SelectPolitMon(3);
        }

        Console.WriteLine("Choose your opponent:");
        Console.WriteLine("1 - Donald Trump");
        Console.WriteLine("2 - Volodymyr Zelensky");
        Console.WriteLine("3 - Vladimir Putin");
        Console.WriteLine("4 - Tomio Okamura");

        string opponentChoice = Console.ReadLine();


        if (opponentChoice == "1")
        {
            enemyCoach.AddPolitMon(trump);
        }
        else if (opponentChoice == "2")
        {
            enemyCoach.AddPolitMon(zelensky);
        }
        else if (opponentChoice == "3")
        {
            enemyCoach.AddPolitMon(putin);
        }
        else
        {
            enemyCoach.AddPolitMon(okamura);
        }

        enemyCoach.SelectPolitMon(0);

        PolitMon player = playerCoach.ActivePolitMon;
        PolitMon opponent = enemyCoach.ActivePolitMon;

        while (player.IsAlive() && opponent.IsAlive())
        {
            Console.WriteLine();
            Console.WriteLine("--- YOUR TURN ---");
            Console.WriteLine("1 - Basic attack");
            Console.WriteLine("2 - Special attack");
            Console.WriteLine("3 - Heal");

            string attackChoice = Console.ReadLine();

            if (attackChoice == "1")
            {
                player.UseBaseAttack(opponent);
            }
            else if (attackChoice == "2")
            {
                player.UseSpecialAttack(opponent);
            }
            else if (attackChoice == "3")
            {
                player.Heal(20);
                Console.WriteLine(player.Name + " healed 20 HP");
            }

            if (opponent.IsAlive())
            {
                Console.WriteLine();
                Console.WriteLine("--- ENEMY TURN ---");

                int enemyChoice = random.Next(1, 4);

                if (enemyChoice == 1)
                {
                    opponent.UseBaseAttack(player);
                }
                else if (enemyChoice == 2)
                {
                    opponent.UseSpecialAttack(player);
                }
                else
                {
                    opponent.Heal(20);
                    Console.WriteLine(opponent.Name + " healed 20 HP");
                }
            }
            player.PrintInfo();
            opponent.PrintInfo();
        }

        Console.WriteLine();

        if (player.IsAlive())
        {
            Console.WriteLine("You won!");
            playerCoach.LevelUp();
            Console.WriteLine("Trainer level: " + playerCoach.GetLevel());
        }
        else
        {
            Console.WriteLine("You lost!");
        }
    }
}
