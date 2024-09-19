﻿const int MAX_PERSONS = 30000;
Inventory inventory = new Inventory();
Person[] persons = new Person[MAX_PERSONS];



bool menuLoop = true;





string[] menuOptions = {
    "Add New Equipment to Inventory",
    "Lend Equipment",
    "Return Equipment",
    "Delete Equipment",
    "Show all equipment borrowed by everyone",
    "Show Inventory",
    "Exit"
};

int MenuOptions()
{
    //show the user the available menu options
    Console.WriteLine("\nInventory System Menu:");
    for(int i =0; i < menuOptions.Length; i++) {
        Console.WriteLine("{0}. {1}", i + 1, menuOptions[i]);
    }

    //prompt the user for a selection option
    Console.Write($"Enter your choice 1-{menuOptions.Length}:");
    if(int.TryParse(Console.ReadLine(), out int choice)){
        return choice;
    }

    return 0;
}

Item NewItem()
{
    Item item = null;
    int id;
    string name;
    string category;

    while(true)
    {
        Console.Write("Item Id:");
        if(int.TryParse(Console.ReadLine(), out id) && id > 0)
            break;
        
        Console.WriteLine("Item Id must be a digit greater than 0!");
    }

    while(true)
    {
        Console.Write("Item Category:");
        category = Console.ReadLine();
        if(!string.IsNullOrEmpty(category))
            break;
        
        Console.WriteLine("Category cannot be empty or null");
    }

    while (true)
    {
        Console.Write("Item Name:");
        name = Console.ReadLine();

        if(!string.IsNullOrEmpty(name))
            break;
        
        Console.WriteLine("Item name cannot be empty or null");

    }

    return new Item(id, name, category);
    
}

while(menuLoop) {
    int choice = MenuOptions();
    switch(choice)
    {
        case 1:
            Item item = NewItem();
            if(inventory.Add(item)) {
                Console.WriteLine("New Item successfully added");
            }
            else {
                Console.WriteLine("Unable to add new item!");
            }
            break;
        case 2:
        break;
        case 3:
        break;
        case 4:
        break;
        default:
            Console.WriteLine($"Invalid input! Please enter a choice of 1-{menuOptions.Length}");
            break;
    }
}

