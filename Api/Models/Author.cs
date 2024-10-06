namespace Api.Models
{
    public class Author : EntityBase<Guid>
    {
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Bio { get; set; } = string.Empty;

        public List<Article> Articles { get; set; } = [];
    }
}