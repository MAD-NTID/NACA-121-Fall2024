const double COMMISSION_RATE = .07;
const double SALES = 10000;

//prompt the user for the sales amount
Console.Write("Sales:");

//get the sale amount from the user and 
//store it in a variable called saleInput
double saleInput = double.Parse(Console.ReadLine());

// if(saleInput >= SALES)
// {
//     //create a variable that calculate and store the commission 
//     //formula: saleInput * Commission rate
//     double totalCommission = saleInput * COMMISSION_RATE;
//     Console.WriteLine("Your commission is : " + totalCommission);
// } else {
//     Console.WriteLine("You get zero commission");
// }

double totalCommission = 0;
if(saleInput >= SALES)
{
    //create a variable that calculate and store the commission 
    //formula: saleInput * Commission rate
    totalCommission = saleInput * COMMISSION_RATE;
} 

Console.WriteLine($"Your commission is {totalCommission:C}");
