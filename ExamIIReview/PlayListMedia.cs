public abstract class PlayListMedia<T>:IPlayListMedia<T>
{
    private protected int totalMedia;
    public int TotalMedia { get{return this.totalMedia;} }

    public abstract void Add(T media);


    public abstract T Play();


    public abstract T ShowNextMedia();

}