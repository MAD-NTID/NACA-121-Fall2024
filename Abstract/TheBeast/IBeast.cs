public interface IBeast
{
    public string Name{get;}
    public int MaxHealthPoint{get;set;}
    public int CurrentHealthPoint{get;set;}

    public void TakeDamage(IAttack attack);
    public abstract IAttack Attack();
}