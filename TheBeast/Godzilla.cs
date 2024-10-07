using System.Linq.Expressions;

public class Godzilla:Beast
{
    


    public Godzilla(string name, int currentHealthPoint, int maxHealthPoint):base(name, currentHealthPoint, maxHealthPoint)
    {
    }

    public override IAttack Attack()
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

    public override void TakeDamage(IAttack attack)
    {
        
      
        if(attack.Name == "fire" ){
            int points = (int)(this.CurrentHealthPoint * 0.30);
            attack.Damage = points;
        }
        
        base.TakeDamage(attack);
    }
}