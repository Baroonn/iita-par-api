using System;
using System.Collections.Generic;

namespace PAR.Infrastructure.Models;

public partial class TraProgram
{
    public long Id { get; set; }

    public string Title { get; set; } = null!;

    public string? Location { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? Trainers { get; set; }

    public string? Funding { get; set; }

    public string? Type { get; set; }

    public double? Participants { get; set; }

    public double? ParticipantsFemale { get; set; }

    public string? MaterialAvailable { get; set; }

    public string? Contact { get; set; }

    public string? Email { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime LastUpdated { get; set; }

    public string LastUpdatedBy { get; set; } = null!;

    public long? Iitauserid { get; set; }

    public int? Version { get; set; }

    public string? Program { get; set; }

    public string? CostCenter { get; set; }

    public string? ProjectNo { get; set; }

    public string? FundSource { get; set; }

    public string? TrainingDescription { get; set; }

    public string? Purpose { get; set; }

    public string? Outcome { get; set; }

    public DateTime? ExtensionDate { get; set; }

    public virtual User? Iitauser { get; set; }
}
