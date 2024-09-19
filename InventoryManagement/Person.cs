
/// <summary>
/// Represents a Person who can borrow and return items.
/// The Person has a unique ID, a name, and can borrow up to a maximum of 10,000 items.
/// Provides methods to borrow and return equipment, with each borrowed item being tracked.
/// </summary>
public class Person
{
    private const int MAX_ITEMS_BORROWED = 10000;


    private int id;
    public int Id
    {
        get { return id; }
        set { id = value; }
    }
    
    private string name;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    private Item[] itemsBorrowed;
    public Item[] ItemsBorrowed
    {
        get { return itemsBorrowed; }
    }

    public Person()
    {
        Name = "Person - No Value supplied";
        Id = -1;
       itemsBorrowed = new Item[MAX_ITEMS_BORROWED];
    }

    public Person(int id, string name)
    {
        Name = name;
        Id = id;
        itemsBorrowed = new Item[MAX_ITEMS_BORROWED];
    }

    private const int MAX_ITEMS = 10000;

    public bool BorrowEquipment(Item item)
    {
        //may be able to borrow if the array is not full
        for(int i = 0; i < itemsBorrowed.Length; i++) {
            //we will search through the array if we find an available spot
            //if a specific spot is null then it is avaialble
            if(itemsBorrowed[i] == null) {
                //since the specific location is null, we can put the item borrow at that specific location
                itemsBorrowed[i] = item;
                //return true since we were successfully able to borrow the item
                return true;
            }
        }

        //cannot borrow
        return false;
    }

    public bool ReturnEquipment(Item item)
    {
        //a person may only return an item if they have that specific item on their borrow list
        for(int i = 0; i < itemsBorrowed.Length; i++) 
        {
            //we can compare the items id, if we get a match then we can return the the item
            if(itemsBorrowed[i]!=null && itemsBorrowed[i].Id == item.Id) {
                //the items id match so we will "remove" the item from the person's borrow list by making that location null since we cannot change
                //an array's size
                itemsBorrowed[i] = null;

                //the item has been successfully returned
                return true;
            }
        }

        //item was not returned, we get here if we never find a match in the id
        return false;
    }
}