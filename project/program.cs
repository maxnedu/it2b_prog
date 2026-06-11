class Program
{
    static Random random = new Random();
    static void Main()
    {
        Texts texts = new Texts();

        Console.ForegroundColor = ConsoleColor.Red;
        texts.TypeIntro();
        Console.ResetColor();

        Coach playerCoach = CreateCoach();

        ChoosePlayer(playerCoach);

        PolitMon player = playerCoach.ActivePolitMon;

        List<PolitMon> enemies = CreateEnemies(playerCoach, player);

        ShowEnemies(enemies);

        bool continueG = true;

        while (continueG)
        {
            foreach (PolitMon opponent in enemies)
            {
                bool won = Fight(player, opponent);

                if (!won)
                {
                    Console.WriteLine("You lost!");
                    return;
                }

                Reward(player);
            }

            Console.WriteLine();
            Console.WriteLine("You defeated all opponents!");
            Console.WriteLine("You are the champion!");
            Console.WriteLine("Do you want to continue?");
            Console.WriteLine("1 - Finish game");
            Console.WriteLine("2 - Continue with stronger enemies");

            string finalChoice = Console.ReadLine();

            if (finalChoice == "1")
            {
                continueG = false;
                Console.WriteLine("Game finished!");
            }
            else
            {
                MakeStronger(enemies);
                Console.WriteLine("Enemies became stronger!");
                ShowEnemies(enemies);
            }
        }
    }
             
    static Coach CreateCoach()
    {
        Attack bombing = new Attack("Bombing", 10, "He just loves to bomb countries.");
        Attack sanctions = new Attack("Sanctions", 25, "Economic pressure attack.");

        Attack budgetSteal = new Attack("Budget steal", 28, "Secretly transfers money from the state budget to his friends.");
        Attack populism = new Attack("Populism", 12, "A loud populist attack.");

        Attack propaganda = new Attack("Propaganda", 14, "Confuses the opponent.");
        Attack gasPressure = new Attack("Gas Pressure", 24, "Uses energy pressure.");

        Attack mediaResponse = new Attack("Media response", 15, "Explains why everything is actually going according to plan.");
        Attack oneMore = new Attack("One more", 23, "Promises this will definitely be the last strike.");

        Coach playerCoach = new Coach("Player");

        PolitMon trump = new PolitMon("Donald Trump", 100, 3, bombing, sanctions);
        PolitMon zelenskyi = new PolitMon("Volodymyr Zelenskyi", 90, 4, populism, budgetSteal);
        PolitMon putin = new PolitMon("Vladimir Putin", 110, 2, propaganda, gasPressure);
        PolitMon netanyahu = new PolitMon("Benjamin Netanyahu", 85, 5, mediaResponse, oneMore);

        playerCoach.AddPolitMon(trump);
        playerCoach.AddPolitMon(zelenskyi);
        playerCoach.AddPolitMon(putin);
        playerCoach.AddPolitMon(netanyahu);

        return playerCoach;
    }

    static void ChoosePlayer(Coach playerCoach)
    {
        Console.WriteLine();
        Console.WriteLine("Choose your PolitMon:");
        Console.WriteLine("1 - Donald Trump");
        Console.WriteLine("2 - Volodymyr Zelenskyi");
        Console.WriteLine("3 - Vladimir Putin");
        Console.WriteLine("4 - Benjamin Netanyahu");

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
    }

    static List<PolitMon> CreateEnemies(Coach playerCoach, PolitMon player)
    {
        List<PolitMon> enemies = new List<PolitMon>();

        foreach (PolitMon politmon in playerCoach.PolitMons)
        {
            if (politmon != player)
            {
                enemies.Add(politmon);
            }
        }

        return enemies;
    }

    static bool Fight(PolitMon player, PolitMon opponent)
    {
        Console.WriteLine();
        Console.WriteLine("Next opponent is: " + opponent.Name);

        player.Health = player.MaxHealth;
        opponent.Health = opponent.MaxHealth;

        player.HealUse = false;
        player.SpecialUse = false;

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
                player.SpecialUse = false;
            }
            else if (attackChoice == "2")
            {
                if (!player.SpecialUse)
                {
                    player.UseSpecialAttack(opponent);
                    player.SpecialUse = true;
                }
                else
                {
                    Console.WriteLine("Special attack is recharging!");
                    Console.WriteLine("You use basic attack instead.");
                    player.UseBaseAttack(opponent);
                    player.SpecialUse = false;
                }
            }
            else if (attackChoice == "3")
            {
                if (!player.HealUse)
                {
                    player.Heal(20);
                    player.HealUse = true;
                    Console.WriteLine(player.Name + " healed 20 HP");
                    Console.WriteLine("Be careful, you can't use it anymore in this fight");
                }
                else
                {
                    Console.WriteLine("You already used healing!");
                    Console.WriteLine("You lose your turn");
                }

                player.SpecialUse = false;
            }
            else
            {
                Console.WriteLine("Wrong choice. You lost your turn.");
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

        if (player.IsAlive())
        {
            Console.WriteLine();
            Console.WriteLine("You defeated " + opponent.Name + "!");
            return true;
        }

        return false;
    }
    static void Reward(PolitMon player)
    {
        Console.WriteLine("Choose reward:");
        Console.WriteLine("1 - +10 Max HP");
        Console.WriteLine("2 - +2 Attack Bonus");

        string reward = Console.ReadLine();

        if (reward == "1")
        {
            player.MaxHealth += 10;
            player.Health = player.MaxHealth;
        }
        else
        {
            player.AttackBonus += 2;
        }
    }

    static void MakeStronger(List<PolitMon> enemies)
    {
        foreach (PolitMon enemy in enemies)
        {
            enemy.MaxHealth += 20;
            enemy.Health = enemy.MaxHealth;
            enemy.AttackBonus += 3;
        }
    }
    static void ShowEnemies(List<PolitMon> enemies)
    {
        Console.WriteLine();
        Console.WriteLine("Your opponents:");

        foreach (PolitMon enemy in enemies)
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("Name: " + enemy.Name);
            Console.WriteLine("HP: " + enemy.MaxHealth);
            Console.WriteLine("Attack bonus: " + enemy.AttackBonus);
            Console.WriteLine("Basic attack: " + enemy.BaseAttack.Name + " - " + enemy.BaseAttack.Info);
            Console.WriteLine("Special attack: " + enemy.SpecialAttack.Name +  " - " + enemy.SpecialAttack.Info);
        }

        Console.WriteLine("--------------------");
    }
}
