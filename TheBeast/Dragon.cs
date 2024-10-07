public class Dragon : Beast
{
    private bool breathed;

    public Dragon():base("DEFAULT_NAME",0,0)
    {
        this.breathed = false;
    }


    public Dragon(string name, int currentHealthPoint, int maxHealthPoint):base(name, currentHealthPoint, maxHealthPoint)
    {
        this.weakness= "Electricity";
    
    }

    public override IAttack Attack()
    {
        IAttack[] attacks = {
            new Attack("Punch", 20),
            new Attack("Underwater drowning", 30),
            new Attack("Fire", 50)
        };

        Random rand = new Random();

        int pick = rand.Next(0, attacks.Length);

        return attacks[pick];
    }

    public override void TakeDamage(IAttack attack)
    {
        
        if(attack.Name == "spike" ){
            int points = (int)(this.CurrentHealthPoint * 0.30);
            attack.Damage = points;
        }
        base.TakeDamage(attack);
 
    }

    public string Breath()
    {
        this.breathed = true;
        return  "FIRE!!!!";
    }

    public override bool Equals(object? obj)
    {
        if(!(obj is Dragon))
            return false;
        Dragon dragon = (Dragon)obj;

        return dragon.Name == this.Name && dragon.CurrentHealthPoint == this.CurrentHealthPoint && dragon.MaxHealthPoint == this.MaxHealthPoint;
    }
}