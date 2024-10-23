public class Sale {
    private int count;
    public int Count {
        get; set;
    }

    private double cost;
    public double Cost {
        get; set;
    }

    private string description;
    public string Description {
        get; set;
    }

    public Sale() {}

    public Sale(int count, double cost, string description)
    {
        Count = count;
        Cost = cost;
        Description = description;
    }

    public string ToCSV()
    {
        return $"{Count},{Cost},{Description}";
    }

    public override string ToString()
    {
        return $"Item Count: {Count} Total Cost: {Cost:C} Item: {Description}";
    }
}