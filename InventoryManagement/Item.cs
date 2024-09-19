/// <summary>
/// Represents an item that can be borrowed or returned.
/// The item has attributes such as id, name, category, availability status, and a timestamp for when it was last checked in.
/// Provides methods to check the item in or lend it out, with availability tracked.
/// The id is automatically set to a non-negative value, and default values are assigned for missing names or categories.
/// </summary>

public class Item
{
    private int id;
    private string name;
    private string category;
    private bool available;
    private DateTime checkdInTimeStamp;

    public int Id 
    { 
        get{return id;}
        set
        {
            if(value < 0)
                value = 0;
            
            id = value;
        }
    }

    public string Name 
    {
        get{return name;}
        set
        {
            if(string.IsNullOrEmpty(value))
                value = "Item - No Name";
            
            name = value;
        }
    }

    public string Category 
    {
        get{return category;}
        set
        {
            if(string.IsNullOrEmpty(value))
                value = "Item - No Category";
            
            category = value;
        }
    }

    public bool Available{
        get{return available;}
    }

    public Item()
    {
        Name = "Item - No Name";
        Category = "Item - No Category";
        Id = 0;
        available = true;
        
    }

    public Item(int id, string name, string category)
    {
        Name = name;
        Id = id;
        Category = category;
        available = true;
    }

    public bool CheckIn()
    {
        //the item can only be checked in if it is already loaned out.
        //an item may not be check in if it was not already marked as loanout
        if(available== false){ //if an item's availablity is marked as false then it is loaned out and we are able to check it back in
            available = true; //now we can mark it as available to loan out again since it has been returned
            checkdInTimeStamp = DateTime.Now;

            return true; //the item has been successfully checked in

        }

        //the item cannot be checked in as it is not loaned out
        return false;
    }

    public bool Lend()
    {
        //we may only lend the item if it is available
        if(available) {
            available = false; //update the item's availablity to false as it is now loan out
            return true; //the item has been successfuly loan out
        }

        return false; //the item is not able to lend out
    }


    public override string ToString()
    {
        return $"Id:{id}. Name:{name}, Category:{category}, Availability: {available}";
    }


}