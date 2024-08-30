//prompt the user for a number corresponding to day of the week

//days of the week example
// Console.Write("Enter a day (1-7):");
// int day = int.Parse(Console.ReadLine());

// switch(day)
// {
//     case 1:
//         Console.WriteLine("Today is Sunday");
//         break;
//     case 2:
//         Console.WriteLine("Today is Monday");
//         break;
//     default:
//         Console.WriteLine("Really bruh!");
//         break;
// }


Console.WriteLine("Enter a number:");
int num = int.Parse(Console.ReadLine());

switch(num)
{
    case 1:
    case 2:
        Console.WriteLine("You entred 1 or 2");
        break;
    case 3:
        Console.WriteLine("You entered 3");
        break;
    default:
        Console.WriteLine("This number is not supported yet");
        break;
}
