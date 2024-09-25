public class Ship
{
    private int totalDistanceTravelled;

    public int TotalDistanceTravelled
    {
        get{return totalDistanceTravelled;}
    }

    private int warpSpeed;
    public int WarpSpeed
    {
        get { return warpSpeed; }

    }

    private string name;
    public string Name
    {
        get { return name; }
    }

    private Alien[] crews;
    private int DEFAULT_MAX_CAPACITY = 10;
    private int ZERO = 0;
    private int totalCrew;

    public Ship()
    {
        crews = new Alien[DEFAULT_MAX_CAPACITY];
        totalDistanceTravelled = ZERO;
        warpSpeed = ZERO;
        totalCrew = ZERO;
        name = "Unidentified Flying Object";
    }

    
    public Ship(string _name, int capacity)
    {
        crews = new Alien[capacity];
        totalDistanceTravelled = ZERO;
        warpSpeed = ZERO;
        totalCrew = ZERO;
        name = _name;
    }

    public bool Add(Alien crew)
    {

        int emptyLocation = -1;

        for(int i = 0; i < crews.Length; i++) {
            Alien crewAlreadyOnTheShip = crews[i];

            //just remember where the empty spot is but only once
            if(crewAlreadyOnTheShip == null && emptyLocation ==-1) {
                emptyLocation = i;
            }

            //check for duplication in roles
            if(crew.Role == "Captain" || crew.Role=="Chief Officer"){
                 if(crewAlreadyOnTheShip!=null && crewAlreadyOnTheShip.Role == crew.Role)
                    return false;
            }

        }

        crews[emptyLocation] = crew;
        totalCrew++;
        return true;
        //check the oncoming crew's role
        // //the oncoming crew is a captain or chief officer
        // if(crew.Role == "Captain" || crew.Role=="Chief Officer"){
        //     //compare everyone that is already on the ship with the on coming  crew
           
        //     foreach(Alien crewAlreadyOnTheShip in crews) {
        //     //if both have the same role, they are either a captain or a chief officer
        //     //therefore the onoming cannot be added to the ship
        //         if(crewAlreadyOnTheShip!=null && crewAlreadyOnTheShip.Role == crew.Role)
        //             return false;
        //     }
        // }

        // //find a empty spot and assign it to that location
        // for(int i = 0; i < crews.Length; i++) {
        //     if(crews[i] == null)
        //     {
        //         crews[i] = crew;
        //         break;
        //     }
                
        // }

        // return true;
    }

    public bool Remove(string name)
    {
        for(int i = 0; i < crews.Length; i++) {
            if(crews[i]!=null && crews[i].Name == name)
            {
                crews[i] = null;
                totalCrew--;
                return true;
            }
        }

        return false;
    }

    public void Fly()
    {
        warpSpeed+=3;
        totalDistanceTravelled+=5;
    }

    public void Fly(int speed)
    {
        warpSpeed+=speed;
        int multiple = speed / 3;
        int distance = multiple * 5;
        totalDistanceTravelled+=distance;
    }

    public override string ToString()
    {
        string info = $"Ship Name:{name}\nSpeed:{warpSpeed}\nDistance:{totalDistanceTravelled}\nTotalCrew:{totalCrew}\nCrews:";

        foreach(Alien crew in crews){
            if(crew is not null) {
                info+=$"\t-{crew}\n";
            }
        }

        return info;
    }






}