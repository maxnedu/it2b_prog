class Skrinka
{
    public int Cislo {  get; set; }
    public Student Student { get; set; }

    public Skrinka(int cislo)
    {
        Cislo = cislo;
        Student = null;
    }

    public void PriradStudenta(Student student)
    {
        if(Student != null)
        {
            Student.Skrinka = null;
            Student.MaSkrinku = false;
            Student = null;
        }
        if(student.Skrinka != null)
        {
            student.Skrinka.Student = null;
            student.Skrinka = null;
            student.MaSkrinku = false;
        }

        Student = student;
        Student.Skrinka = this;
        Student.MaSkrinku = true;
    }
}
