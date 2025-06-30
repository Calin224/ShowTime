using System;
using STime.Enums;

namespace STime.Entities;

public class Band : BaseEntity
{
    public required string Name { get; set; }
    public Genre Genre { get; set; }
    public ICollection<Festival> Festivals { get; set; } = [];
}
