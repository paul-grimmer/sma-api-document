using Microsoft.EntityFrameworkCore;
using SMA_api_documents.Models;
using System.Reflection.Metadata;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<DocumentContext>(opt =>
    opt.UseInMemoryDatabase("Documents"));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();

    using (var scope = app.Services.CreateScope())
    {
        var context = scope.ServiceProvider.GetRequiredService<DocumentContext>();
        context.Database.EnsureCreated();

        var doc1 = context.Documents.FirstOrDefault(b => b.Heading == "Document 1");
        if (doc1 == null)
        {
            context.Documents.Add(new SMA_api_documents.Models.Document { 
                Heading = "Document 1", 
                Description = "A description of a document" 
            });

            context.Documents.Add(new SMA_api_documents.Models.Document
            {
                Heading = "Document 2",
                Description = "A description of a different document"
            });

            context.Documents.Add(new SMA_api_documents.Models.Document
            {
                Heading = "Document 3",
                Description = "A description of yet another document"
            });
            context.SaveChanges();
        }
    }

}

app.UseAuthorization();

app.MapControllers();

app.Run();
