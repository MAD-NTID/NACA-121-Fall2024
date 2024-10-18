public class Piece
{
    private string name;
    private string color;

    public string Name{get{return this.name;}}
    public string Color{get{return this.color;}}

    public Piece(string name, string color)
    {
        this.name = name;
        this.color = color;
    }

    public override bool Equals(object? obj)
    {
        //if object is not an instance type of false, they are not the same

  
        
        if((obj is Piece) == false)
            return false;

        //convert object to a piece class 
        Piece piece = (Piece)obj;

        return piece.Name == this.name && piece.Color == this.color;

    }

    public override string ToString()
    {
        return $"{this.name}:{this.color}";
    }
}