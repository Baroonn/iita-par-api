using System;
using System.Collections.Generic;

namespace PAR.Infrastructure.Models;

public partial class P4dsupportactivity
{
    public long Id { get; set; }

    public int? ActivityYear { get; set; }

    public string? AdditionalSuggestions { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? EntryYear { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string? LastUpdatedBy { get; set; }

    public string? NextYearGoals { get; set; }

    public string? ResponsibilityChanges { get; set; }

    public string? ResponsibilityOutputs { get; set; }

    public int? Status { get; set; }

    public string? SuccessAndChallenges { get; set; }

    public int Version { get; set; }

    public long UserId { get; set; }

    public virtual ICollection<P4dsupportachievement> P4dsupportachievements { get; set; } = new List<P4dsupportachievement>();

    public virtual User User { get; set; } = null!;
}
