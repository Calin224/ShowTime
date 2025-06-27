using System;
using Microsoft.EntityFrameworkCore;
using STime.Config;
using STime.Entities;

namespace STime.Data;

public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
{
    public DbSet<Festival> Festivals { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(FestivalConfiguration).Assembly);

        modelBuilder.Entity<Festival>()
            .HasMany(e => e.Bands)
            .WithMany(e => e.Festivals);
    }
}
