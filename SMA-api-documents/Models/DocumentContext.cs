using Microsoft.EntityFrameworkCore;

namespace SMA_api_documents.Models;

public class DocumentContext : DbContext
{
    public DocumentContext(DbContextOptions<DocumentContext> options)
        : base(options)
    {
    }

    public DbSet<Document> Documents { get; set; } = null!;
}
