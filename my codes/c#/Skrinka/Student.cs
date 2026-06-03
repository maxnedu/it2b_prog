class Student
{
    public string Name { get; set; }
    public Skrinka Skrinka { get; set; }
    public bool MaSkrinku { get; set; }

    public Student(string name)
    {
        Name = name;
        Skrinka = null;
        MaSkrinku = false;
    }

}
