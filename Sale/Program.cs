string filePath = "sales.csv";
StreamWriter sw = new(filePath);

Sale[] sales = new Sale[3];
sales[0] = new(5, 50, "Bought 5 meals for the family");
sales[1] = new(2, 4000, "Mac Computers (yeah they greedy)");
sales[2] = new(10, 500, "Groceries");

sw.WriteLine("count,cost,description");
for(int i = 0; i < sales.Length; i++)
   sw.WriteLine(sales[i].ToCSV()); 

sw.Close();

Console.WriteLine("Finished Writing to File");
Console.WriteLine("Now let's Read. Who likes reading right? Well PC reads fast");

if(File.Exists(filePath))
{
    StreamReader sr = new(filePath);

    // Now we need to read the file one line at a time
    bool skipFirstLine = true;
    while(!sr.EndOfStream) {
        // Skip the first line which are the column names, we don't need these for now
        if(skipFirstLine)
        {
            sr.ReadLine();
            skipFirstLine = false;
            continue;   
        }

        // Readline does two things, returns the value of the entire line and moves on to he next one
        string line = sr.ReadLine();

        string[] delimitedLine = line.Split(",");

        // Rebuild that Sale object
        Sale sale = new(
            int.Parse(delimitedLine[0]), 
            double.Parse(delimitedLine[1]), 
            delimitedLine[2]
        );

        // Invoke the Sale's ToString to prove that rebuilding the Sale object from persistent data does work
        Console.WriteLine(sale.ToString());
    }

    sr.Close();
}
else {
    Console.WriteLine("Sorry, could not fine that file path");
}
