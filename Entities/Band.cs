using System;

namespace STime.Entities;

public class Band : BaseEntity
{
    public required string Name { get; set; }
    public string? Genre { get; set; }
    public ICollection<Festival> Festivals { get; set; } = [];
}
