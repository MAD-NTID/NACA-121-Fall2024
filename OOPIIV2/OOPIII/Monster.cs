public class Monster
{
    private int distanceTravelled;
    private double height;
    private double size;

    private string name;

    private double healthPoint;


    public Monster(double _height, double _size, string _name, double _healthPoint)
    {
        height = _height;
        size = _size;
        name = _name;
        healthPoint = _healthPoint;
    }

    public Monster()
    {
        
    }

    public void TakeDamage(int damage)
    {
        if(damage > 0) {
            healthPoint-=damage;
        }
    }

    public void TakeDamage(double damage)
    {
        if(damage > 0) {
            healthPoint-=damage;
        }
    }

    public void TakeDamage(string damage)
    {
        int damageInt = int.Parse(damage);
        if(damageInt > 0) {
            healthPoint-=damageInt;
        }
    }

    public override string ToString()
    {
        return $"Monster info: {name} {healthPoint} {size}";
    }
}