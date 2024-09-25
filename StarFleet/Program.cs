// Alien alien1 = new Alien("Jane Way", "Captain");
// Alien alien2 = new Alien("", "");

// Console.WriteLine(alien1);

// Console.WriteLine(alien2);

Ship ship = new Ship("Voyager", 3000);

string[] menus = {
    "Add Alien to ship",
    "Fly",
    "Fly at a specific speed",
    "Remove an alien from the ship",
    "Show ship information",
    "Exit"
};

int Selection()
{
    Console.WriteLine("Starfleet Federation");

    Console.WriteLine("Menu\n=============");
    for(int i = 0; i< menus.Length; i++) {
        Console.WriteLine($"{i+1}.{menus[i]}");
    }

    Console.Write("Selection:");
    return int.Parse(Console.ReadLine());
}

bool repeat = true;
while(repeat)
{
    try{
        int selection = Selection();
        switch(selection)
        {
            case 1:
                bool added = false;
                do
                {
                    Console.Write("Name:");
                    string _name = Console.ReadLine();
                    Console.Write("Role:");
                    string role = Console.ReadLine();

                    Alien crew = new Alien(_name, role);
                    if(!ship.Add(crew)) {
                        Console.WriteLine("Only 1 Captain or Chief Officer allowed!");       
                    } else {
                        Console.WriteLine($"Successfully added {crew}");
                        added = true;
                    }
                }while(added == false);
                break;
            case 2:
                ship.Fly();
                Console.WriteLine($"{ship.Name} flew {ship.TotalDistanceTravelled} interstellar distance at {ship.WarpSpeed} warp speed");
                break;
            case 3:
                Console.Write("Speed:");
                int speed;
                if(!int.TryParse(Console.ReadLine(), out speed) || speed %3!=0)
                {
                    Console.WriteLine("Invalid speed! Speed must be an integer in mutliple of 3!\n Ship did not fly!");
                } else {
                    ship.Fly(speed);
                    Console.WriteLine($"{ship.Name} flew {ship.TotalDistanceTravelled} interstellar distance at {ship.WarpSpeed} warp speed");
                }
                break;
            case 4:
                Console.Write("Name:");
                string name = Console.ReadLine();
                if(ship.Remove(name)){
                    Console.WriteLine($"{name} was successfully removed");
                } else {
                    Console.WriteLine($"{name} doesn't exist");
                }
                break;
            case 5:
                Console.WriteLine(ship.ToString());
                break;
            case 6:
                Console.WriteLine("Thank you for exploring space with us!");
                repeat = false;
                break;
            default:
                Console.WriteLine("Invalid Selection!");
                break;


        }
    } catch(FormatException e){
        Console.WriteLine("Invalid selection. Input must be a digit!");
    }
}
