using System;
using System.Collections.Generic;

namespace PAR.Infrastructure.Models;

public partial class Kpiachievement
{
    public long Id { get; set; }

    public string? Achievement { get; set; }

    public string? Completion { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? DateCreated { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string? LastUpdatedBy { get; set; }

    public int Version { get; set; }

    public long KpiId { get; set; }

    public virtual Kpi Kpi { get; set; } = null!;
}
