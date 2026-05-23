class Course
{
    public string Name { get; set; }
    public List<Student> Students { get; set; }

    public Course(string name)
    {
        Name = name;
        Students = new List<Student>();
    }

    public void AddStudent(Student student)
    {
        Students.Add(student);
    }
    
    public void ShowInfo()
    {
        Console.WriteLine("The course is " + Name);
        Console.WriteLine("Students: ");
        foreach(Student s in Students)
        {
            Console.WriteLine(s.ShowInfo());
        }
    }
}
class Teacher
{
    public string Name { get; set; }
    public List<Course> Courses { get; set; }

    public Teacher(string name)
    {
        Name = name;
        Courses = new List<Course>();
    }
    public void AddCourse(Course course)
    {
        Courses.Add(course);
    }
    public void ShowInfo()
    {
        Console.WriteLine(Name);
        foreach(Course course in Courses)
        {
            course.ShowInfo();
        }
    }
}
class Student
{
    public string Name { get; set; }
    public string Description { get; set; }

    public Student (string name, string description)
    {
        Name = name;
        Description = description;
    }

    public string ShowInfo()
    {
        return Name + " - " + Description;
    }
}
