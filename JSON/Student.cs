public class Student
{
    public string Name { get; set; }
    public int Year { get; set; }
    public int Age { get; set; }

    public Student(string name, int year, int age)
    {
        Name = name;
        Year = year;
        Age = age;
    }

    public override string ToString()
    {
        return $"Name: {Name}, Academic Year: {Year}, Age: {Age}";
    }
}