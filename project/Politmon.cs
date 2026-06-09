ss PolitMon
{
    public string Name { get; set; }

    public int Health { get; set; }
    public int MaxHealth { get; set; }
    public int AttackBonus { get; set; }

    public Attack BaseAttack { get; set; }
    public Attack SpecialAttack { get; set; }

    public PolitMon(string name, int health, int attackBonus, Attack baseAttack, Attack specialAttack)
    {
        Name = name;
        Health = health;
        MaxHealth = health;
        AttackBonus = attackBonus;
        BaseAttack = baseAttack;
        SpecialAttack = specialAttack;
    }

    public bool IsAlive()
    {
        return Health > 0;
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;

        if (Health < 0)
        {
            Health = 0;
        }
    }

    public void Heal(int amount)
    {
        Health += amount;

        if (Health > MaxHealth)
        {
            Health = MaxHealth;
        }
    }

    public void UseBaseAttack(PolitMon enemy)
    {
        int damage = BaseAttack.GetDamage() + AttackBonus;

        Console.WriteLine(Name + " used " + BaseAttack.Name);
        enemy.TakeDamage(damage);

        Console.WriteLine(enemy.Name + " lost " + damage + " HP");
    }

    public void UseSpecialAttack(PolitMon enemy)
    {
        int damage = SpecialAttack.GetDamage() + AttackBonus;

        Console.WriteLine(Name + " used " + SpecialAttack.Name);
        enemy.TakeDamage(damage);

        Console.WriteLine(enemy.Name + " lost " + damage + " HP");
    }

    public void PrintInfo()
    {
        Console.WriteLine(Name + " HP: " + Health + "/" + MaxHealth);
    }
}
