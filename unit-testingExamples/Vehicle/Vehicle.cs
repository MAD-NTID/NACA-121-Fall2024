public class Vehicle:IVehicle
{
    private string name;
    private string make;
    private int year;
    private int miles;

    public string Name
    {
        get{return this.name;}
        set{
            this.name = value;
        }
    }

    public int Miles{
        get{return this.miles;}
        set{this.miles = value;}
    }


    public Vehicle()
    {
        name = "Undefined";
        make = "Undefined";
        year = 1990;
        miles = 0;
    }

    public Vehicle(string name, string make, int year)
    {
        this.name = name;
        this.make = make;
        this.year = year;
        this.miles = 0;
    }

    public void Drive()
    {
        this.miles+=1;
    }

    public void Drive(int miles)
    {
        this.miles+=miles;
    }
}