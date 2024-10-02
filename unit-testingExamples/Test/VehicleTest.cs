public class VehicleTest
{
    [Test]
    public void TestUndefinedNameProperty()
    {
        //SETUP
        string name = "Undefined";

        //invoke
        Vehicle vehicle = new Vehicle();

        //Analyze
        Assert.AreEqual(name, vehicle.Name);

    }

    [Test]
    public void TestSuppliedNameProperty()
    {
         //SETUP
        string name = "Delorean";

        //invoke
        Vehicle vehicle = new Vehicle(name,"Ford",1970);

        //Analyze
        Assert.AreEqual(name, vehicle.Name);
    }

    [Test]
    public void TestDriveWithNoValueSupplied()
    {
        //setup
        int expected  = 1;

        //invoke
        Vehicle vehicle =  new Vehicle();
        vehicle.Drive();

        //analyze
        Assert.AreEqual(expected, vehicle.Miles);

    }
}