using System;
using System.Collections.Generic;

namespace PAR.Infrastructure.Models;

public partial class Learning
{
    public long Id { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? DateCreated { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string? LastUpdatedBy { get; set; }

    public int Version { get; set; }

    public long UserId { get; set; }

    public long? CourseId { get; set; }

    public long? Year { get; set; }

    public virtual User User { get; set; } = null!;
}
