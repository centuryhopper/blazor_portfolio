namespace Portfolio.Shared;


public class ProjectCardModel
{
    public string? imgUrl { get; set; }
    public string? title { get; set; }
    public string? description { get; set; }
    public string? gameLink { get; set; }
    public string? sourceCodeLink { get; set; }

    public ProjectCardModel(string imgUrl, string title, string description, string gameLink, string sourceCodeLink)
    {
        this.imgUrl = imgUrl;
        this.title = title;
        this.description = description;
        this.gameLink = gameLink;
        this.sourceCodeLink = sourceCodeLink;
    }

    public override string ToString()
    {
        return $"{nameof(imgUrl)}:{imgUrl}, {nameof(title)}:{title}, {nameof(description)}:{description}, {nameof(gameLink)}:{gameLink}, {nameof(sourceCodeLink)}:{sourceCodeLink}, ";
    }

}