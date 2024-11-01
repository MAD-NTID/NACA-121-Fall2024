public class PlayListMediaStack<T> : PlayListMedia<T>
{
    private Stack<T> playlist;
    public PlayListMediaStack()
    {
        this.playlist = new Stack<T>(10000);
    }
    public override void Add(T media)
    {
        this.playlist.Push(media);
    }

    public override T Play()
    {
        return this.playlist.Pop();
    }

    public override T ShowNextMedia()
    {
        return this.playlist.Peek();
    }

    public override string ToString()
    {
        return this.playlist.ToString();
    }
}