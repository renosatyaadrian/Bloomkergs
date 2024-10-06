namespace Api.Models
{
    public class Article : EntityBase<Guid>
    {
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public DateTime PublishedDate { get; set; }
        public Guid CategoryId { get; set; }
        public Guid AuthorId  { get; set; }
        
        public List<ArticleCategory> ArticleCategories { get; set; } = [];
        public Author? Author { get; set; }
    }
}