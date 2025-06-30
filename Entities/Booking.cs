using System;

namespace STime.Entities;

public class Booking : BaseEntity
{
    public string Email { get; set; } = string.Empty;
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    public int FestivalId { get; set; }
    public Festival Festival { get; set; } = null!;
}
