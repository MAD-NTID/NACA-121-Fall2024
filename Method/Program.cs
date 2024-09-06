// int Add(int num1, int num2) //def add(num1, num2)
// {
//     int sum = num1 + num2;
//     return sum;
// }

int Add(int num1, int num2) //def add(num1, num2)
{
    return num1 + num2;
}

int result = Add(7,6);
Console.WriteLine(result);

Console.WriteLine("The result is:" + Add(7,6));

void GreetHuman(string human)
{
    Console.WriteLine("Hello human:"+ human);
    return ;//optional
}

GreetHuman("Kemoy");

int Subtract(int num1, int num2 = 5)
{
    return num1- num2;
}

Console.WriteLine(Subtract(5,10));

Console.WriteLine(Subtract(5));

bool Convert(string numeric, out int number)
{
    number = int.Parse(numeric);
    return true;
}

/*
def convert(numeric):
    return true, int(numeric)
*/
int result2;
bool success = Convert("2", out result2);
if(success)
    Console.WriteLine(result2);


