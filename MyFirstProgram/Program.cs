//SEE THE PYTHON CODE IN UNIT 01 - SLIDE 16

string option = "3";

if(option == "1" || option == "2")
    Console.WriteLine("You chose option " + option);
else if(option == "3")
    Console.WriteLine($"choice {option} is magnificient!");
else
    Console.WriteLine("You did not choose a valid option");

//Understanding WriteLine
Console.WriteLine("Hello NACA"); //Console.Write("Hello NACA\n");