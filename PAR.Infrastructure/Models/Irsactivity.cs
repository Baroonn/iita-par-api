using System;
using System.Collections.Generic;

namespace PAR.Infrastructure.Models;

public partial class Irsactivity
{
    public long Id { get; set; }

    public int? ActivityYear { get; set; }

    public byte[]? AdditionalSuggestions { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? EntryYear { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string? LastUpdatedBy { get; set; }

    public byte[]? NextYearGoals { get; set; }

    public byte[]? ResponsibilityChanges { get; set; }

    public byte[]? ResponsibilityOutputs { get; set; }

    public int? Status { get; set; }

    public byte[]? SuccessAndChallenges { get; set; }

    public int Version { get; set; }

    public long UserId { get; set; }

    public virtual ICollection<Irsachievement> Irsachievements { get; set; } = new List<Irsachievement>();

    public virtual User User { get; set; } = null!;
}
