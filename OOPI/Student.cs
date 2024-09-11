public class Student
{
    //class attributes
    public string name;
    public string major;
    public double gpa;

    public Student()
    {
        name = "N/A";
        major = "UNDECIDED";
        gpa = 0.0;
    }

    public Student(string _name, string _major, double _gpa)
    {
        name = _name;
        major = _major;
        gpa = _gpa;
    }
}