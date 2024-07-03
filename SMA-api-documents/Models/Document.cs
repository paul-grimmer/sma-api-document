namespace SMA_api_documents.Models
{
    public class Document
    {
        public long Id { get; set; }
        public DateTime LastUpdated { get; set; }
        public DateTime Created { get; set; }

        public string? Heading { get; set; }
        public string? Description { get; set; }

    }
}
