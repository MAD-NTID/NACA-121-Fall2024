int[] numbers = new int[5];

//assign 7 at index 0
numbers[0] = 7;

Console.WriteLine(numbers[0]);

//printing the values using a loop
Console.WriteLine();
for(int i = 0; i < numbers.Length; i++)
    Console.WriteLine(numbers[i]);

Console.WriteLine();
foreach(int num in numbers) //for num in numbers
    Console.WriteLine(num);

string name ="Kemoy Campbell";
foreach(char letter in name)
    Console.WriteLine(letter);


//user determines the size of the array
int[] number2;

Console.Write("How many numbers:");
int size = int.Parse(Console.ReadLine());

number2 = new int[size];

//assigning values to an array without specifying the size
int[] number3 = {1,2,3,4,5,6,7};
//number3[0] = 1
//number3[1] = 2
//number3[2] = 3