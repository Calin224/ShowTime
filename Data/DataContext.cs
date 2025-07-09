using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using STime.Config;
using STime.Entities;

namespace STime.Data;

public class DataContext(DbContextOptions<DataContext> options) : IdentityDbContext(options)
{
    public DbSet<Festival> Festivals { get; set; }
    public DbSet<Band> Bands { get; set; }
    public DbSet<Booking> Bookings { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(FestivalConfiguration).Assembly);

        modelBuilder.Entity<Festival>()
            .HasMany(e => e.Bands)
            .WithMany(e => e.Festivals);
    }
}
