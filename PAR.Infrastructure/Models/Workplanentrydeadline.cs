using System;
using System.Collections.Generic;

namespace PAR.Infrastructure.Models;

public partial class Workplanentrydeadline
{
    public long Id { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string? LastUpdatedBy { get; set; }

    public int Version { get; set; }

    public string? Category { get; set; }

    public DateTime? Deadline { get; set; }

    public int WorkplanYear { get; set; }

    public long? UserId { get; set; }

    public virtual User? User { get; set; }
}
