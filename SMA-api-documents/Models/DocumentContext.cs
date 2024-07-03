using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace SMA_api_documents.Models;

public class DocumentContext : DbContext
{
    public DocumentContext(DbContextOptions<DocumentContext> options)
        : base(options)
    {
    }
    

    public DbSet<Document> Documents { get; set; } = null!;
}
