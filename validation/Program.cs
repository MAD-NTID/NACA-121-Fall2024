//Console.Write("Enter a number:");
//int number = int.Parse(Console.ReadLine());

// bool successfulConverted = int.TryParse(Console.ReadLine(), out int number);
// if(successfulConverted){
//     Console.WriteLine($"You entered:{number}");
// } else {
//     Console.WriteLine("Really bruh!");
// }

//not a great practice. What if the input is 0?
//NOT RECOMMEND... DONT DO THIS
// int.TryParse(Console.ReadLine(), out int number);

// if(number!=0){
//     Console.WriteLine("We did it!!!");
// } else {
//     //didnt converted.. show default value
//     Console.WriteLine(number);
// }


/***
number = input("Enter a number:")
if(number.isdigit()):
    //something
    number = int(number)
else:
    //something else
*/
//IsDigit(string value) --> use try parse

bool IsDigit(string value)
{
    return int.TryParse(value, out int number);
    // if(int.TryParse(value, out int number))
    //     return true;
    
    // return false;
}

Console.WriteLine(IsDigit("55"));
Console.WriteLine(IsDigit("E"));

//buidling our own tryparse... WHY? Because we can!
bool TryParse(string value, out int number)
{
    try{
        number = int.Parse(value);
        return true;
    }
    catch
    {
        number = 0;
        return false;
    }
}







