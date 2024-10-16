Printer<int> printer = new Printer<int>(5);


for(int i = 0; i < 6; i++)
{
    Console.WriteLine(printer.Add(i));
}

Console.WriteLine(printer.Cancel(4));
Console.WriteLine("\nPrinting the elements:\n");
for(int i = 0; i < 5; i++) {
    Console.WriteLine(printer.Print());
}


Console.WriteLine(printer.Cancel(4));

Printer<string> printerString = new Printer<string>(5);
for(int i = 0; i < 6; i++)
{
    Console.WriteLine(printerString.Add(i.ToString()));
}


Console.WriteLine("\nPrinting the elements:\n");
for(int i = 0; i < 5; i++) {
    Console.WriteLine(printerString.Print());
}

