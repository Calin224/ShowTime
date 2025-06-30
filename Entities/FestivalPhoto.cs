using System;

namespace STime.Entities;

public class FestivalPhoto : BaseEntity
{
    public required string Url { get; set; }
    public string? PublicId { get; set; }

    public int FestivalId { get; set; }
    public Festival Festival { get; set; } = null!;
}
