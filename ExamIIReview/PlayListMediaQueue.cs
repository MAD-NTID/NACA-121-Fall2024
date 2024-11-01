public class PlayListMediaQueue<T> : PlayListMedia<T>
{
    private Queue<T> playlist;

    public PlayListMediaQueue()
    {
        this.playlist = new Queue<T>(10000);
    }
    public override void Add(T media)
    {
        this.playlist.Enqueue(media);
    }

    public override T Play()
    {
        return this.playlist.Dequeue();
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