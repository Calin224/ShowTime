using System;
using System.ComponentModel.DataAnnotations;

namespace STime.Entities;

public class Festival : BaseEntity
{
    public required string Location { get; set; } = string.Empty;
    public required string Name { get; set; } = string.Empty;
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string Description { get; set; } = string.Empty;
    public string? Url { get; set; }
    public string? PublicId { get; set; }

    public ICollection<Band> Bands { get; set; } = [];
    public ICollection<Booking> Bookings { get; set; } = [];
}
