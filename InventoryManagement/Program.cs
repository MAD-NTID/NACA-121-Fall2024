﻿// Define a constant to represent the maximum number of persons
const int MAX_PERSONS = 30000;

// Create an instance of the Inventory class to hold all items
Inventory inventory = new Inventory();

// Create an array to store up to MAX_PERSONS persons
Person[] persons = new Person[MAX_PERSONS];

// Initialize a boolean variable to control the menu loop
bool menuLoop = true;

// Define an array of string to hold the different menu options available to the user
string[] menuOptions = {
    "Add New Equipment to Inventory",
    "Lend Equipment",
    "Return Equipment",
    "Delete Equipment",
    "Show all equipment borrowed by everyone",
    "Show Inventory",
    "Exit"
};

// Function to display menu options to the user and get their choice
int MenuOptions()
{
    // Display the menu title
    Console.WriteLine("\nInventory System Menu:");
    
    // Loop through the menu options and print each one with a number
    for (int i = 0; i < menuOptions.Length; i++) {
        Console.WriteLine("{0}. {1}", i + 1, menuOptions[i]);
    }

    // Prompt the user to make a choice based on the available options
    Console.Write($"Enter your choice 1-{menuOptions.Length}:");
    
    // Attempt to parse the user's input and return the choice if valid
    if (int.TryParse(Console.ReadLine(), out int choice)){
        return choice;
    }

    // Return 0 if the input is not a valid number
    return 0;
}

// Function to create a new Item based on user input
Item NewItem()
{
    int id;
    string name;
    string category;

    // Get a valid item ID from the user
    while (true)
    {
        Console.Write("Item Id:");
        if (int.TryParse(Console.ReadLine(), out id) && id > 0)
            break; // Break the loop if the input is a valid number greater than 0
        
        Console.WriteLine("Item Id must be a digit greater than 0!");
    }

    // Get a valid item category from the user
    while (true)
    {
        Console.Write("Item Category:");
        category = Console.ReadLine();
        if (!string.IsNullOrEmpty(category))
            break; // Break the loop if the input is not null or empty
        
        Console.WriteLine("Category cannot be empty or null");
    }

    // Get a valid item name from the user
    while (true)
    {
        Console.Write("Item Name:");
        name = Console.ReadLine();
        if (!string.IsNullOrEmpty(name))
            break; // Break the loop if the input is not null or empty
        
        Console.WriteLine("Item name cannot be empty or null");
    }

    // Create a new Item object using the provided id, name, and category
    Item item = new Item(id, name, category);
    
    // Return the newly created item
    return item;
}

// Menu loop to repeatedly show the menu and execute the user's choice
while (menuLoop)
{
    // Get the user's choice by calling the MenuOptions method
    int choice = MenuOptions();

    // Switch statement to handle each menu option
    switch (choice)
    {
        // Case 1: Add new equipment to the inventory
        case 1:
            // Get new item details from the user
            Item item = NewItem();
            
            // Try adding the item to the inventory
            if (inventory.Add(item)) {
                Console.WriteLine("New Item successfully added");
            } else {
                Console.WriteLine("Unable to add new item!");
            }
            break;

        // Case 2: Lend equipment (this section is currently empty)
        case 2:
            break;

        // Case 3: Return equipment (this section is currently empty)
        case 3:
            break;

        // Case 4: Delete equipment (this section is currently empty)
        case 4:
            break;

        // Case 5: Show all equipment borrowed by everyone (this section is currently empty)
        case 5:
            break;

        // Case 6: Show available inventory in the system
        case 6:
            // Get available equipment from the inventory
            string equipments = inventory.ShowAvailableEquipments();
            
            // Display the equipment list if available, otherwise show a message
            if (equipments != "") {
                Console.WriteLine(inventory.ShowAvailableEquipments());
            } else {
                Console.WriteLine("No inventory to show");
            }
            break;

        // Default case for invalid input
        default:
            // Inform the user that their input is invalid
            Console.WriteLine($"Invalid input! Please enter a choice of 1-{menuOptions.Length}");
            break;
    }
}