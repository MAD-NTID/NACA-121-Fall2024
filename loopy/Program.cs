//inital value
// int counter = 1;

// while(counter < 10)
// {
//     Console.WriteLine($"Counter value:{counter}");
//     counter++; //increment the counter
// }

//for loop 
//int counter1 = 1;
// for(int counter1 = 1; counter1 < 10; counter1++) {

//     if(counter1 %2 == 0)
//         Console.WriteLine($"Counter:{counter1} is even");
//     else
//         Console.WriteLine($"Counter:{counter1} is odd");
// }

//forever looping
// while(true) {
//     Console.Write("Enter a string:");
//     string input = Console.ReadLine();

//     if(input == "exit"){
//         Console.WriteLine("Exiting....");
//         break;
//     }
//     Console.WriteLine($"You typed:{input}");
// }

// int balance = 100;
// int amount = 0;
// while(true) {
//     Console.Write("Enter the balance to withdrew:");
//     amount = int.Parse(Console.ReadLine());

//     if(amount < 0 || amount > balance)
//         Console.WriteLine("Invalid amount!");
//     else
//         break;

// }

// balance = balance - amount;
// Console.WriteLine($"Your balance:{balance}");

// int count = 0;
// while(count < 10)
// {
    
//     if(count %2!=0)
//         continue;
    
//     Console.WriteLine(count);
//     count++;
    
// }

// int balance = 200;
// while(true) 
// {
//     Console.Write("Enter the amount to withdrew:");
//     int amount = int.Parse(Console.ReadLine());

//     if(amount < 0 || amount > balance) {
//         Console.WriteLine("Invalid balance");
//         continue;
//     }

//     Console.WriteLine("We will withdraw here");
// }


string name;
do
{
    Console.Write("Enter your name:");
    name = Console.ReadLine();
}while(name == "");

Console.WriteLine($"Hello {name}");


