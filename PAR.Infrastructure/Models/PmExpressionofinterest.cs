using System;
using System.Collections.Generic;

namespace PAR.Infrastructure.Models;

public partial class PmExpressionofinterest
{
    public string Idea { get; set; } = null!;

    public string? Proposal { get; set; }

    public string? Project { get; set; }

    public string? Macroproject { get; set; }

    public string? Title { get; set; }

    public string? Objective { get; set; }

    public string? ResearchSite { get; set; }

    public int? Duration { get; set; }

    public int? ExpectedYear { get; set; }

    public long? TotalBudget { get; set; }

    public string? ActionsTaken { get; set; }

    public string? NextSteps { get; set; }

    public string? Comments { get; set; }

    public string? Status { get; set; }

    public long? CenterContribution { get; set; }

    public DateTime? Submission { get; set; }

    public string? Goal { get; set; }

    public string? Purpose { get; set; }

    public string? Description { get; set; }

    public string? ExpectedResult { get; set; }

    public string? PotentialBeneficiaries { get; set; }

    public string? RejectionReason { get; set; }

    public string? MtpProject { get; set; }

    public DateTime? ContractDate { get; set; }

    public string? Leader { get; set; }

    public string? Donor { get; set; }

    public string? Topic { get; set; }

    public string? Discipline { get; set; }

    public string? Crop { get; set; }

    public long Id { get; set; }
}
