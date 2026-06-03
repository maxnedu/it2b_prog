class Cichnamon
{
    public string Name { get; set; }

    public int Health { get ; set; }
    public int MaxHealth { get; set; }
    public int AttackBonus { get; set; }
    public Attack BaseAttack { get; set; }
    public Attack SpecialAttack { get; set; }


    public Cichnamon(string name, int health, int attackBonus)
    {
        Name = name;
        Health = health;
        AttackBonus = attackBonus;
    }
    public bool IsAlive()
    {
        if(Health <= 0)
        {
            return false;
        }
        return true;
    }
    public void PrintInfo()
    {
        Console.WriteLine("Basic character stats:");
        Console.WriteLine("The name is: " + Name + "Health is: " + Health);
        BaseAttack.PrintInfo();
    }
}
