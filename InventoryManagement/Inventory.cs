/// <summary>
/// The Inventory class represents a collection of items with a maximum capacity. 
/// It provides methods to add items, loan out items, and return items. 
/// Each item in the inventory can be loaned out only if available, and can be returned if it has been loaned.
/// The class handles the internal management of items, ensuring that the inventory is not overfilled and that 
/// items can be borrowed or returned based on their availability status.
/// </summary>
public class Inventory
{
    private const int MAX_ITEMS = 100000;
    private int count;
    private Item[] items;

    /// <summary>
    /// Gets the array of items currently in the inventory.
    /// </summary>
    public Item[] Items
    {
        get { return items; }
    }

    /// <summary>
    /// Initializes a new instance of the Inventory class with a maximum capacity of 100,000 items.
    /// </summary>
    public Inventory()
    {
        items = new Item[MAX_ITEMS];
    }

    /// <summary>
    /// Adds an item to the inventory if there is space available. 
    /// The item is added to the first available (null) spot in the items array.
    /// </summary>
    /// <param name="item">The item to be added to the inventory.</param>
    /// <returns>True if the item was successfully added, false if the inventory is full.</returns>
    public bool Add(Item item)
    {
        for (int i = 0; i < items.Length; i++)
        {
            if (items[i] == null)
            {
                items[i] = item;
                count++;
                return true;
            }
        }
        return false;
    }

    /// <summary>
    /// Returns an item to the inventory by marking it as checked in.
    /// The item must exist in the inventory and must have been previously loaned out.
    /// </summary>
    /// <param name="itemId">The ID of the item to be returned.</param>
    /// <returns>True if the item was successfully returned, false if the item was not found or is already checked in.</returns>
    public bool Return(int itemId)
    {
        for (int i = 0; i < items.Length; i++)
        {
            Item item = items[i];

            if (item != null && item.Id == itemId)
            {
                return item.CheckIn();
            }
        }
        return false;
    }

    /// <summary>
    /// Loans out an item from the inventory by marking it as unavailable.
    /// The item must exist in the inventory and must be available to be loaned out.
    /// </summary>
    /// <param name="itemId">The ID of the item to be loaned out.</param>
    /// <returns>True if the item was successfully loaned out, false if the item was not found or is already loaned out.</returns>
    public bool LoanOut(int itemId)
    {
        for (int i = 0; i < items.Length; i++)
        {
            Item item = items[i];

            if (item != null && item.Id == itemId)
            {
                return item.Lend();
            }
        }
        return false;
    }

    public string ShowAvailableEquipments()
    {
        string equipment = "";
        for(int i = 0;  i < items.Length; i++) {
            if (items[i] != null && items[i].Available) {
                equipment+=items[i].ToString() + "\n";
            }
        }

        return equipment;
    }
}
