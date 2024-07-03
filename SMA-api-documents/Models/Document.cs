namespace SMA_api_documents.Models
{
    public class Document
    {
        public long Id { get; set; }
        public DateTime LastUpdated { get; set; } = DateTime.Now;
        public DateTime Created { get; set; } = DateTime.Now;

        public string? Heading { get; set; }
        public string? Description { get; set; }

    }
}
