// string filePath = "sales.csv";
// StreamWriter sw = new(filePath);

// Sale sale1 = new(5, 50, "Bought 5 meals for the family");

// Sale sale2 = new();
// sale2.Count = 2;
// sale2.Cost = 4000;
// sale2.Description = "Mac Computers (yeah they greedy)";

// Sale sale3 = new(10, 500, "Groceries");

// sw.WriteLine("count,cost,description");
// sw.WriteLine($"{sale1.Count},{sale1.Cost},{sale1.Description}");
// sw.WriteLine($"{sale2.Count},{sale2.Cost},{sale2.Description}");
// sw.WriteLine($"{sale3.Count},{sale3.Cost},{sale3.Description}");
// sw.Close();

// Console.WriteLine("Finished Writing to File");
// Console.WriteLine("Now let's Read. Who likes reading right? Well PC reads fast");

// if(File.Exists("someWRongPathOnPurpose.csv"))
// {
//     StreamReader sr = new(filePath);

//     // Now we need to read the file one line at a time
//     while(!sr.EndOfStream) {
//         // Readline does two things, returns the value of the entire line and moves on to he
//         //  next one
//         Console.WriteLine(sr.ReadLine());
//     }
// }
// else {
//     Console.WriteLine("Sorry, could not fine that file path");
// }
