namespace Api.Models
{
    public class Category : EntityBase<Guid>
    {
        public string Name { get; set; } = string.Empty;

        public List<ArticleCategory> ArticleCategories { get; set; } = [];
    }
}