public abstract class Beast:IBeast
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
    
    protected string weakness;

    public Beast(string name, int currentHealthPoint, int maxHealthPoint)
    {
        this.Name = name;
        this.CurrentHealthPoint = currentHealthPoint;
        this.MaxHealthPoint = maxHealthPoint;
    }

    public virtual void TakeDamage(IAttack attack)
    {
       int points = attack.Damage;
       this.CurrentHealthPoint-=points;
    }

    public abstract IAttack Attack();
}