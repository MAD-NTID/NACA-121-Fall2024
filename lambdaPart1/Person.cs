public class Person
{
    private string name;

    public string Name{get => name; set => name=value;}

    //using lambda
    public double Cost() => 5* 25;

    //using normal approach
    // public double Cost()
    // {
    //     return 5*25;
    // }

}