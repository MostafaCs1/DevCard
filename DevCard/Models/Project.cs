namespace DevCard.Models
{
	public class Project
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public string ClientName { get; set; }
        public string ImageName { get; set; }

        public Project(int id, string name, string description, string clinetName, string imageName)
        {
            Id = id;
			Name = name;
			Description = description;
			ClientName = clinetName;
			ImageName = imageName;
        }
    }
}
