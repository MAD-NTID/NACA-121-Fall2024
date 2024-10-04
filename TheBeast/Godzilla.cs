using System.Linq.Expressions;

public class Godzilla : IBeast
{
    
    private string name;
    private int maxHealthPoint, currentHealthPoint;
    public string Name {
        get{return name;}
        set{name=value;}
     }

   
    public int MaxHealthPoint {
        get{return maxHealthPoint;}
        set{maxHealthPoint = value;}
     }
    public int CurrentHealthPoint { 
        get{return currentHealthPoint;}
        set{currentHealthPoint = value;}
     }

    public Godzilla(string name, int currentHealthPoint, int maxHealthPoint)
    {
        this.name = name;
        this.currentHealthPoint = currentHealthPoint;
        this.maxHealthPoint = maxHealthPoint;
    }

    public IAttack Attack()
    {
        IAttack[] attacks = {
            new Attack("Punch", 20),
            new Attack("Smash", 30),
            new Attack("Spike", 50)
        };

        Random rand = new Random();

        int pick = rand.Next(0, attacks.Length);

        return attacks[pick];
    }

    public void TakeDamage(IAttack attack)
    {
        
        int points = attack.Damage;
        if(attack.Name == "fire" ){
            points = (int)(this.currentHealthPoint * 0.30);
        }
        
        this.currentHealthPoint-=points;
    }
}