public class Dragon : Beast
{


    public Dragon(string name, int currentHealthPoint, int maxHealthPoint)
    {
        this.Name = name;
        this.CurrentHealthPoint = currentHealthPoint;
        this.MaxHealthPoint = maxHealthPoint;
    }

    public IAttack Attack()
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

    public void TakeDamage(IAttack attack)
    {
        int points = attack.Damage;
        if(attack.Name == "spike" ){
            points = (int)(this.CurrentHealthPoint * 0.30);
        }

        this.CurrentHealthPoint-=points;
    }
}