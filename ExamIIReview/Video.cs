public class Video
{
    private string title, category, duration;

    public string Title { get{return title;} }
    public string Duration { get{return duration;} }
    public string Category { get{return category;} }

    public Video(string title, string duration,string category)
    {
        this.title = title;
        this.duration  = duration;
        this.category = category;
    }

    public override string ToString()
    {
        return $"{title},{category},{duration}";
    }
}