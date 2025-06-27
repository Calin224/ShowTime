using System;
using System.ComponentModel.DataAnnotations;

namespace STime.Entities;

public class Festival : BaseEntity
{
    public required string Location { get; set; }
    public required string Name { get; set; }
    public TimeSpan Period { get; set; }
    public string Description { get; set; } = string.Empty;
    public ICollection<Band> Bands { get; set; } = [];
}
