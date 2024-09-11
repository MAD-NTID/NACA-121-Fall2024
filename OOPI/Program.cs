
Student travis = new Student();
travis.name = "Travis Braun";
travis.major = "Game Design";
travis.gpa = 2.5;
PrintStudentRecord(travis);


Student usfer = new Student("Usfer", "Software Engineering", 1.5);

// Console.WriteLine(usfer.name);
// Console.WriteLine(usfer.gpa);
PrintStudentRecord(usfer);


Student justin = new Student();
// Console.WriteLine(justin.name);
PrintStudentRecord(justin);

void PrintStudentRecord(Student student)
{
    Console.WriteLine($"Name:{student.name},Major:{student.major},GPA:{student.gpa}");
}