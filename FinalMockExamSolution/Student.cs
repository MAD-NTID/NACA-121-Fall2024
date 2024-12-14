
public class Student : IStudent
{
    private string firstName;
    private string lastName;
    private List<DateTime> attendanceDates;

    public Student(string firstName, string lastName, List<DateTime> attendanceDates)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.attendanceDates = attendanceDates;
    }


    public string FirstName => firstName;

    public string LastName => lastName;

    public List<DateTime> AttendanceDates => attendanceDates;

    public void AddAttendance(DateTime date)
    {
        attendanceDates.Add(date);
    }
}