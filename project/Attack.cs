
class Attack
{
    public string Name { get; set; }
    public int Damage { get; set; }
    public string Info { get; set; }

    public Attack(string name, int damage, string info)
    {
        Name = name;
        Damage = damage;
        Info = info;
    }
    public void PrintInfo()
    {
        Console.WriteLine("Basic info: ");
        Console.WriteLine(Info);
    }
    
    public int GetDamage() { return Damage; }
}
