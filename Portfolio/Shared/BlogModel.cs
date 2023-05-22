namespace Portfolio.Shared;

public class BlogModel
{
    public string title;
    public DateTime date;
    public string previewDesc;
    public string routeName;
    public List<VideoUrlModel>? videoUrls;
    public string fullDesc;
    public string Id;

    public BlogModel(string Id, string title, DateTime date, string previewDesc, string routeName, string fullDesc, List<VideoUrlModel>? videoUrls = null)
    {
        this.Id = Id;
        this.title = title;
        this.date = date;
        this.previewDesc = previewDesc;
        this.routeName = routeName;
        this.videoUrls = videoUrls;
        this.fullDesc = fullDesc;
    }

    public override string ToString()
    {
        return $"{nameof(Id)}: {Id}, {nameof(title)}: {title}, {nameof(date)}: {date}, {nameof(previewDesc)}: {previewDesc}, {nameof(routeName)}: {routeName},";
    }
}

