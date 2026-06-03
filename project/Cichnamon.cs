class Cichnamon
{
    public string Name { get; set; }

    public int Health { get ; set; }
    public int MaxHealth { get; set; }
    public int AttackBonus { get; set; }
    public Attack BaseAttack { get; set; }
    public Attack SpecialAttack { get; set; }


    public Cichnamon(string name, int health, int attackBonus, Attack baseAttack, Attack specialAttack)
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
        if(Health > 0)
        {
            return true;
        }
        return false;
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

}
