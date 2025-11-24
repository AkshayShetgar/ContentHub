using Microsoft.EntityFrameworkCore;
using SyncSyntax.Models;

namespace SyncSyntax.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}
        public DbSet<Post> posts { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Comment> comments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>()
                .HasData(
                    new Category { Id = 1, Name = "Technology", Description = "Posts related to technology." },
                    new Category { Id = 2, Name = "Health", Description = "Posts related to health and wellness." },
                    new Category { Id = 3, Name = "LifeStyle", Description = "Posts about LifeStyle." }
                );
            modelBuilder.Entity<Post>()
                .HasData(
                    new Post { Id = 1, Title = "The Rise of AI", Content = "Artificial Intelligence is transforming the world.", CategoryId = 1, Author = "Akshay", ImagePath = "Akki.jpeg", PublishedDate = new DateTime(2025, 11, 11) },
                    new Post { Id = 2, Title = "Healthy Living Tips", Content = "Tips for a healthier lifestyle.", CategoryId = 2, Author = "Sagar", ImagePath = "Akki.jpeg", PublishedDate = new DateTime(2025, 11, 11) },
                    new Post { Id = 3, Title = "LifeStyle", Content = "Content of LifeStyle.", CategoryId = 3, Author = "Ankita", ImagePath = "Akki.jpeg", PublishedDate = new DateTime(2025, 11, 11) }
                );
        } 
    }
}
