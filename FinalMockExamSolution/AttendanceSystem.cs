
using Newtonsoft.Json;

public class AttendanceSystem : IAttendanceSystem
{

    private Dictionary<string, IStudent> students;

    public AttendanceSystem()
    {
        students = new Dictionary<string, IStudent>();
    }


    public void AddStudent(string firstName, string lastName, DateTime attendanceDate)
    {
        string key = $"{firstName}{lastName}";

        //check if the student already exist
        //if the student key doesnt exist then we need to create the student object
        if (!students.ContainsKey(key))
        {
            //create the student object
            IStudent student = new Student(firstName, lastName, new List<DateTime>());

            //add the student to the dictionary
            students.Add(key, student);
        }

        //we will update the student's attendance dates
        students[key].AddAttendance(attendanceDate);
    }

    public void AddStudent(string firstName, string lastName, List<DateTime> attendanceDate)
    {
        //we can utilize the AddStudent method we created above and just pass the list of dates,
        //it will create the new student only once if it doesnt exist and add the dates to the student
        foreach (DateTime date in attendanceDate)
        {
            AddStudent(firstName, lastName, date);
        }
    }

    public void LoadAttendanceFromFile(string filePath)
    {
        //check if the file exist
        if (!File.Exists(filePath))
        {
            //option 1
            throw new FileNotFoundException("File not found", filePath);

            //option 2 you could use console.WrtieLine to print out the error message
        }

        //create stream reader object
        StreamReader reader = new StreamReader(filePath);

        //skip the header
        reader.ReadLine();

        //read the file line by line
        while(!reader.EndOfStream)
        {
            //read in the content of the current line
            string content = reader.ReadLine();

            //based on the student_records.csv, the file is format as
            //FirstName,LastName,Date1,Date2,Date3,Date4,Date5,Date6,Date7

            //split the content by comma and store in an array
            string[] tokens = content.Split(',');
            string firstName = tokens[0];
            string lastName = tokens[1];

            //create a list of dates
            List<DateTime> dates = new List<DateTime>();
            for(int i = 2; i < tokens.Length; i++)
            {
                //convert the string to date
                DateTime date = DateTime.Parse(tokens[i]);
                dates.Add(date);
            }

            //add the student to the dictionary by using AddStudent method - the one that supports list of dates
            AddStudent(firstName, lastName, dates);

        }
    }

    public void SaveAttendanceToFile(string filePath)
    {
        //create stream writer object
        StreamWriter writer = new StreamWriter(filePath);

        //serialize the data using newtonsoft json serialize
        string json = JsonConvert.SerializeObject(students);

        //store it to the file
        writer.WriteLine(json);
        writer.Close();

    }

    public List<IStudent> SelectStudentsByDateRange(DateTime fromDate, DateTime toDate)
    {
 
        //recall that the students is a dictionary that have key value pair,
        //the key is the student's first name and last name concatenated while the value is the IStudent object,
        //we are interested in list of students so we will need to use the values property of the dictionary

        List<IStudent> allStudents = students.Values.ToList();

        //we want to use lambda linq to filter by the date range
        //first we will need the where then we will filter by date

        //filter the students by date range
        //we are filtered by 2 things, the students and matching the date range
        //so we only want students that meet specific date range criteria
        List<IStudent> filteredStudents = allStudents.Where(student => student.AttendanceDates.Any(date => date >= fromDate && date <= toDate)).ToList();

        return filteredStudents;


    }

    public List<IStudent> SortStudentsByLastName()
    {
        //Since the instruction asked for O(N^2) sorting time complexity, we can use insertion sort
        //we will need to convert the dictionary values to list
        List<IStudent> allStudents = students.Values.ToList();

        //insertion sort
        for (int i = 1; i < allStudents.Count; i++)
        {
            IStudent key = allStudents[i];
            int j = i - 1;

            while (j >= 0 && string.Compare(allStudents[j].LastName, key.LastName) > 0)
            {
                allStudents[j + 1] = allStudents[j];
                j = j - 1;
            }
            allStudents[j + 1] = key;
        }

        return allStudents;
    }
}