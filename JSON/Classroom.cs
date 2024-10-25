public class Classroom
{
    private string teacher;
    public string Teacher
    {
        get
        {
            return teacher;
        }

        set
        {
            teacher = value;
        }
    }

    public string[] Interpreters { get; set; }
    public int Room { get; set; }
    public Student[] Students { get; set; }

    public Classroom(Student[] students, string teacher, string[] interpreters, int room)
    {
        Students = students;
        Teacher = teacher;
        Interpreters = interpreters;
        Room = room;
    }

    // NOTE this has nothing to do with JSON, it's only for returning the data of this object.
    public override string ToString()
    {
        string students = $"Room: {Room}, Teacher: {Teacher}\n\nTerps: ";

        foreach (string terps in Interpreters)
            students += $"{terps}\n";

        students += $"\nStudents: ";

        foreach (Student student in Students)
            students += $"{student}\n";

        return students;
    }
}