using Microsoft.EntityFrameworkCore;
using ProductiFlow.Domain.Models;

namespace ProductiFlow.Infrastructure.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<User>().ToTable("Users"); //renaming table

        modelBuilder.Entity<User>().HasIndex(u => u.Email).IsUnique(); //difine the email as unique
    }
}