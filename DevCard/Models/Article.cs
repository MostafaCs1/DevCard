namespace DevCard.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public string ImageName { get; set; }

        public Article(int id, string name, string description, string clinetName, string imageName)
        {
            Id = id;
            Title = name;
            Description = description;
            ImageName = imageName;
        }
    }
}
