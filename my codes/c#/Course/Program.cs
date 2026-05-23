class Program ()
{
    static void Main()
    {
        Student student = new Student("Alex", "Alex is 18 and love cars");
        Student student2 = new Student("John", "John is 19 and loves traveling");
        Student student3 = new Student("Ben", "Ben is 20 and  loves cycling");


        Course course = new Course("English");
        Course course2 = new Course("Math");

        course.AddStudent(student);
        course2.AddStudent(student2);
        course.AddStudent(student3);

        Teacher teacher = new Teacher("Karl");
        teacher.AddCourse(course);
        teacher.AddCourse(course2);
        teacher.ShowInfo();
        

     
    }
}
