using System;
using System.Collections.Generic;

namespace PAR.Infrastructure.Models;

public partial class P4dworkplan
{
    public long Id { get; set; }

    public int? ActivityYear { get; set; }

    public string? ActualOutcome { get; set; }

    public string? BeneficiaryCountries { get; set; }

    public string? Categories { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? EntryYear { get; set; }

    public string? Impact { get; set; }

    public string? IntendedUser { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string? LastUpdatedBy { get; set; }

    public string? OpenAccess { get; set; }

    public string? Outcome { get; set; }

    public string? OutcomePathway { get; set; }

    public string? OutputTarget { get; set; }

    public int? OutputTargetYear { get; set; }

    public string? Outputs { get; set; }

    public string? ProductLine { get; set; }

    public string? Project { get; set; }

    public string? Region { get; set; }

    public int? Status { get; set; }

    public int Version { get; set; }

    public long UserId { get; set; }

    public string? CgPriorities { get; set; }

    public DateTime? DateCreated { get; set; }

    public virtual ICollection<P4dactivity> P4dactivities { get; set; } = new List<P4dactivity>();

    public virtual User User { get; set; } = null!;
}
