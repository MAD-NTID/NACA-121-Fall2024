IAttendanceSystem attendanceSystem = new AttendanceSystem();
bool exit = false;

while (!exit)
{
    Console.WriteLine("\nAttendance System Menu:");
    Console.WriteLine("1. Load attendance data from file");
    Console.WriteLine("2. Save attendance data to file");
    Console.WriteLine("3. Add Student attendance");
    Console.WriteLine("4. Sort students by last name");
    Console.WriteLine("5. Select students by date range");
    Console.WriteLine("6. Exit");
    Console.Write("Enter your choice (1-5): ");

    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            Console.Write("Enter the file path to load attendance data from: ");
            string loadFilePath = Console.ReadLine();
            attendanceSystem.LoadAttendanceFromFile(loadFilePath);
            Console.WriteLine("Attendance data loaded successfully.");
            break;
        
        case "2":
            Console.Write("Enter the file path to save attendance data to: ");
            string saveFilePath = Console.ReadLine();
            attendanceSystem.SaveAttendanceToFile(saveFilePath);
            Console.WriteLine("Attendance data saved successfully.");
            break;
        case "3":
            Console.Write("Enter Student First Name: ");
            string firstName = Console.ReadLine() ?? "";

            Console.Write("Enter Student Last Name: ");
            string lastName = Console.ReadLine() ?? "";

            Console.Write("Enter the Attendance Date (yyyy-MM-dd): ");
            //if there are multiple dates, they are separated with a ,.. see the screenshot output for example
            string attendanceDate = Console.ReadLine();

            List<DateTime> attendances = [];

            if( attendanceDate != null && attendanceDate.Contains(","))
            {
                //we can use linq to convert the string to list of dates
                //option1
                attendances = attendanceDate.Split(",")
                                 .Select(x => DateTime.Parse(x))
                                 .ToList();
                
                //you can also use for loop to convert the string to list of dates
                //option2
                // foreach(string date in attendanceDate.Split(","))
                // {
                //     attendances.Add(DateTime.Parse(date));
                // }
            }

            //option 1 - You can also do this
            // foreach(DateTime date in attendances)
            // {
            //     attendanceSystem.AddStudent(firstName, lastName, date);
            // }

            //option 2
            if (attendances.Count > 0)
                attendanceSystem.AddStudent(firstName, lastName, attendances);
            else
                attendanceSystem.AddStudent(firstName, lastName, DateTime.Parse(attendanceDate));   

            Console.WriteLine("Student Attendance Added Successfully");
            break;

        case "4":
            List<IStudent> sortedStudents = attendanceSystem.SortStudentsByLastName();
            Console.WriteLine("Students sorted by last name:");
            foreach (var student in sortedStudents)
            {
                Console.WriteLine($"{student.LastName}, {student.FirstName}");
            }
            break;

        case "5":
            Console.Write("Enter the start date (yyyy-MM-dd): ");
            DateTime fromDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter the end date (yyyy-MM-dd): ");
            DateTime toDate = DateTime.Parse(Console.ReadLine());
            List<IStudent> studentsInRange = attendanceSystem.SelectStudentsByDateRange(fromDate, toDate);
            Console.WriteLine($"\nStudents who attended class between {fromDate.ToShortDateString()} and {toDate.ToShortDateString()}:");
            foreach (var student in studentsInRange)
            {
                Console.WriteLine($"{student.LastName}, {student.FirstName}");
            }
            break;
        case "6":
            exit = true;

            //bonus
            //if there is no json file, prompt the administrator if they want to save the file
            Console.Write("Do you want to save the attendance data to a file? (Y/N): ");
            string save = Console.ReadLine();
            if (save.ToLower() == "y")
            {
                Console.Write("Enter the file path to save attendance data to: ");
                string filename = Console.ReadLine();
                if(!string.IsNullOrEmpty(filename) && File.Exists(filename)) {
                    Console.WriteLine("Skipping save to the file as the filename is null or the file already exists.");
                } else if(!File.Exists(filename)) {
                    attendanceSystem.SaveAttendanceToFile(filename);
                    Console.WriteLine("Attendance data saved successfully.");
                }
                
            }
            Console.WriteLine("Exiting the program...");
            break;
        default:
            Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
            break;
    }
}