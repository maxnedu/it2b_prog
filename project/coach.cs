class Coach
{
    public string Name { get; set; }

    private int level;

    public List<PolitMon> PolitMons { get; set; }

    public PolitMon ActivePolitMon { get; set; }

    public Coach(string name)
    {
        Name = name;
        level = 1;
        PolitMons = new List<PolitMon>();
    }

    public void AddPolitMon(PolitMon politMon)
    {
        PolitMons.Add(politMon);
    }

    public void SelectPolitMon(int index)
    {
        ActivePolitMon = PolitMons[index];
    }

    public void LevelUp()
    {
        level++;
    }

    public int GetLevel()
    {
        return level;
    }
}
