using System.Globalization;

namespace Calculator;

public class MagicCalculator
{
    public int Add(int a, int b)
    {
        return a+b;
    }

    public double Add(double a, int b)
    {
        return a+b;
    }

    public int Add(int[] elements)
    {
        int sum = 0;
        foreach(int number in elements)
        {
            sum+=number;
        }

        return sum;
    }
}
