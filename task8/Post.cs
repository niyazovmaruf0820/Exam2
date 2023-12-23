class Post
{
    public string title;
    public string description;
    public int LikesCount = 0;
    public bool isPublished = true;
     public List<string> Commentary = new List<string>();

    public void TheTitle(string _title)
    {
        title = _title;
    }
    public string IsPublished(){
        return $"The post is published.";
    }
    public void TheDescription(string _description)
    {
        description = _description;
    }

    public void Like()
    {
        LikesCount++;
    }

    public void Comment(string comment)
    {
        Commentary.Add(comment);
    }

    public string Infomation()
    {
        return $"Title : {title} \nDescription : {description}Likes : {LikesCount}";
    }
}