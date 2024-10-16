public class Attack:IAttack
{
    private string name;
    private int damage;

    public string Name { get => name; set => name=value; }
    public int Damage { get => damage; set => damage=value; }

    public Attack(string name, int damage)
    {
        this.name = name;
        this.damage = damage;
    }
}