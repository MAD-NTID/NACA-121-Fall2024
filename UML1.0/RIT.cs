public class RIT
{
    private Student[] students;


    public RIT()
    {
        students = new Student[10];
    }

    public RIT(int capacity)
    {
        students = new Student[capacity];
    }

    public void Add(Student student)
    {
        for(int i = 0; i < students.Length; i++){
            if(students[i] is null) {
                students[i] = student;
                break;
            }
        }
    }
}