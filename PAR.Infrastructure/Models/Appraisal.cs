using System;
using System.Collections.Generic;

namespace PAR.Infrastructure.Models;

public partial class Appraisal
{
    public long Id { get; set; }

    public string? Comments { get; set; }

    public string? CommitteeMember { get; set; }

    public double FinalScore { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string? LastUpdatedBy { get; set; }

    public string? StaffComments { get; set; }

    public string? State { get; set; }

    public string? Strengths { get; set; }

    public string? TrainingNeeds { get; set; }

    public int Version { get; set; }

    public string? Weaknesses { get; set; }

    public int YearOfAppraisal { get; set; }

    public long? AppraiseeId { get; set; }

    public long AppraiserId { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? AppraiseeId1 { get; set; }

    public string? AppraiseeName { get; set; }

    public string Type { get; set; } = null!;

    public string? CompletedTraining { get; set; }

    public string? DisciplinaryAction { get; set; }

    public string? ManageStaff { get; set; }

    public string? AdditionalComments { get; set; }

    public string? IrsEffectiveness { get; set; }

    public string? JobTitle { get; set; }

    public string? Suggestions { get; set; }

    public string? Unit { get; set; }

    public string? Project { get; set; }

    public string? RatingSummary { get; set; }

    public string? JuniorManageStaff { get; set; }

    public long? CountryId { get; set; }

    public string? Justification { get; set; }

    public DateOnly? Eligibility { get; set; }

    public string? Appeal { get; set; }

    public string? Research { get; set; }

    public string? Selfappraised { get; set; }

    public virtual ICollection<Appraisalcommittee> Appraisalcommittees { get; set; } = new List<Appraisalcommittee>();

    public virtual ICollection<Appraisalevaluator> Appraisalevaluators { get; set; } = new List<Appraisalevaluator>();

    public virtual ICollection<Appraisalscore> Appraisalscores { get; set; } = new List<Appraisalscore>();

    public virtual Country? Country { get; set; }

    public virtual ICollection<Staffcommentlog> Staffcommentlogs { get; set; } = new List<Staffcommentlog>();
}
