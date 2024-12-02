double Square(double a)
{
    return a*a;
}

// Func<double, double> lambdaSquare = (double a) => a*a;
var lambdaSquare = (double a) => a*a;
Console.WriteLine(Square(5));
Console.WriteLine(lambdaSquare(5));
