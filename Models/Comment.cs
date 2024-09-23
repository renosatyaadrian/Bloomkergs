namespace Bloomkergs.Models
{
    public class Comment : EntityBase<Guid>
    {
        public Guid ArticleId { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string? Email { get; set; }
        public string CommentText { get; set; } = string.Empty;
        public DateTime CommentDate { get; set; }

        public Article? Article { get; set; }
    }
}