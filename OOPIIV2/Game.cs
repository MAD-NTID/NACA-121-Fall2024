public class Game
{
    private int loots;
    private int deaths;

    public int Deaths{get{return deaths;}}


    public Game()
    {
        loots = 0;
    }

    public void PickUpLoot()
    {
        loots++;
    }

    public void StealLoot()
    {
        loots--;
    }
}