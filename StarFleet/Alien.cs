public class Alien
{
    private string name;
    private string role;

    public string Name{
        set{
            if(string.IsNullOrEmpty(value))
                value = "Undefined";

            name = value;

            // if(string.IsNullOrEmpty(value)) {
            //     name = "Undefined";
            // } else {
            //     name = value;
            // }
        }
        get{
            return name;
        }
    }

    private bool IsValidRole(string role)
    {
        string[] acceptableRoles = {
            "Captain",
            "Chief Officer",
            "Navigator",
            "Pilot",
            "Engineer",
            "Doctor"
        };

        foreach(string role2 in acceptableRoles) {
            if(role == role2)
                return true;
        }

        return false;
    }

    public string Role{
        set{
            if(!IsValidRole(value))
                value = "Unknown role";
            
            role = value;
        }
        get{
            return role;
        }
    }

    public Alien(string _name, string _role)
    {
        Name = _name;
        Role = _role;
    }

    public override string ToString()
    {
        return $"Name:{name} Role:{role}";
    }


}