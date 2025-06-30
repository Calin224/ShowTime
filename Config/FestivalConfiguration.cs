using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using STime.Entities;

namespace STime.Config;

public class FestivalConfiguration : IEntityTypeConfiguration<Festival>
{
    public void Configure(EntityTypeBuilder<Festival> builder)
    {
        builder.Property(x => x.Name).HasColumnType("nvarchar(100)");
        builder.Property(x => x.Name).IsRequired();

        builder.Property(x => x.StartDate).IsRequired();
        builder.ToTable(tb =>
            tb.HasCheckConstraint("CK_Festival_StartDate_Future", "StartDate > GETDATE()")
        );
    }
}
