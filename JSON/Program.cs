using Newtonsoft.Json;

StreamWriter sw = new("students.json");

Student student1 = new("Erik", 4, 99);
Student student2 = new("Justin", 2, 14);
Student student3 = new("Shawn", 2, 15);
Student student4 = new("Travis", 2, 9);
Student student5 = new("Usfer", 2, 25);

Student[] students = new Student[5];
students[0] = student1;
students[1] = student2;
students[2] = student3;
students[3] = student4;
students[4] = student5;

string[] terps = new string[2];
terps[0] = "Catherine";
terps[1] = "Emily";

Classroom naca121 = new(students, "KC", terps, 2355);

// Serialize the Whole Classroom
sw.WriteLine(JsonConvert.SerializeObject(naca121));
sw.Close();

// Read from file
StreamReader sr = new("students.json");

// Deserialize the Whole Classrom from JSON string in the json file
Classroom naca121Rebuilt = JsonConvert.DeserializeObject<Classroom>(sr.ReadToEnd());

// Invoke the ToString() method of the Classroom object which will show everything
Console.WriteLine(naca121Rebuilt);
sr.Close();