public class Card
{
    private string color;
    private string animal;
    private bool isFlipped;

    public string Color{
        get{
            return color;
        }
    }

    public string Animal{
        get{
            return animal;
        }
    }

    public bool IsFlipped
    {
        get{
            return this.isFlipped;
        }
    }

    public Card(string color, string animal)
    {
        this.color = color;
        this.animal = animal;
        this.isFlipped = false;
    }

    public override string ToString()
    {
        string info = "card:*";

        if(this.isFlipped)
            info = $"card:{animal}/{color}";

        return info;;
    }

    public void Reveal()
    {
        this.isFlipped = true;
    }

    public void Hide()
    {
        this.isFlipped = false;
    }
}