public class Student
{
    private string name;
    private string major;
    private double gpa;

    public string Name{
        get{
            return name;
        }
    }


    public override string ToString()
    {
        return $"Name:{name} Major:{major} GPA:{gpa}";
    }
}