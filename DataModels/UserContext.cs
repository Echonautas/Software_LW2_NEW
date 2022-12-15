using Microsoft.EntityFrameworkCore;
using Software.Design.Models;

namespace Software.Design.DataModels;

public class Context : DbContext
{
    public Context(DbContextOptions options) : base(options)
    {
    }

    public DbSet<F1> Database => Set<F1>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<F1>()
            .HasKey(b => b.Id);

        modelBuilder.Entity<F1>().ToTable("drivers", schema: "f1");
    }
}