class Program
{
    static void Main()
    {
        Random random = new Random();

        Texts texts = new Texts();
        Console.ForegroundColor = ConsoleColor.Red;
        texts.TypeIntro();
        Console.ResetColor();

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

        Console.WriteLine();
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

        PolitMon player = playerCoach.ActivePolitMon;

        List<PolitMon> enemies = new List<PolitMon>();

        foreach (PolitMon politmon in playerCoach.PolitMons)
        {
            if (politmon != player)
            {
                enemies.Add(politmon);
            }
        }

        bool continueg = true;

        while (continueg)
        {
            foreach (PolitMon opponent in enemies)
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
                    string secondChoice = "0";

                    if (attackChoice == "1")
                    {
                        player.UseBaseAttack(opponent);
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
                            Console.WriteLine("Try something else: 1 - Basic attack; 2 - Heal");

                            secondChoice = Console.ReadLine();

                            if (secondChoice == "1")
                            {
                                player.UseBaseAttack(opponent);
                            }
                            else if (secondChoice == "2")
                            {
                                if (!player.HealUse)
                                {
                                    player.Heal(20);
                                    player.HealUse = true;
                                    Console.WriteLine(player.Name + " healed 20 HP");
                                }
                                else
                                {
                                    Console.WriteLine("You already used healing!");
                                }
                            }
                        }
                    }
                    else if (attackChoice == "3")
                    {
                        if (!player.HealUse)
                        {
                            player.Heal(20);
                            player.HealUse = true;
                            Console.WriteLine(player.Name + " healed 20 HP");
                        }
                        else
                        {
                            Console.WriteLine("You already used healing!");
                        }
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

                    if (attackChoice == "1" || attackChoice == "3" || secondChoice == "1" || secondChoice == "2")
                    {
                        player.SpecialUse = false;
                    }
                }

                if (player.IsAlive())
                {
                    Console.WriteLine();
                    Console.WriteLine("You defeated " + opponent.Name + "!");

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
                else
                {
                    Console.WriteLine("You lost!");
                    return;
                }
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
                continueg = false;
                Console.WriteLine("Game finished!");
            }
            else
            {
                foreach (PolitMon enemy in enemies)
                {
                    enemy.MaxHealth += 20;
                    enemy.Health = enemy.MaxHealth;
                    enemy.AttackBonus += 3;
                }

                Console.WriteLine("Enemies became stronger!");
            }
        }
    }
}
