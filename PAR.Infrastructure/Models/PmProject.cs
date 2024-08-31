using System;
using System.Collections.Generic;

namespace PAR.Infrastructure.Models;

public partial class PmProject
{
    public string Project { get; set; } = null!;

    public string? Idea { get; set; }

    public string? Proposal { get; set; }

    public string? Macroproject { get; set; }

    public string? Title { get; set; }

    public string? ResearchSite { get; set; }

    public int? Duration { get; set; }

    public DateTime? StartingDate { get; set; }

    public DateTime? EndingDate { get; set; }

    public int? TechnicalReport { get; set; }

    public int? FinancialReport { get; set; }

    public long? TotalBudget { get; set; }

    public string? Currency { get; set; }

    public long? OriginalCurrency { get; set; }

    public string? ExtensionIndicator { get; set; }

    public string? ConditionalIndicator { get; set; }

    public string? TerminationIndicator { get; set; }

    public int? PartnerIndicator { get; set; }

    public int? CashflowIndicator { get; set; }

    public string? ProjType { get; set; }

    public long? CiatBudget { get; set; }

    public int? AuditPeriodicity { get; set; }

    public int? ReviewPeriodicity { get; set; }

    public int? Overhead { get; set; }

    public string? Goal { get; set; }

    public string? Purpose { get; set; }

    public string? Description { get; set; }

    public string? ExpectedResult { get; set; }

    public string? PotentialBeneficiaries { get; set; }

    public string? EmailRemind { get; set; }

    public string? SubContract { get; set; }

    public DateTime? LastExtensionDate { get; set; }

    public string? Topic { get; set; }

    public string? Discipline { get; set; }

    public string? Crop { get; set; }

    public string? Stitle { get; set; }

    public string? ForWeb { get; set; }

    public string? Agreement { get; set; }

    public string? Pass { get; set; }

    public string? RegionalDd { get; set; }

    public string? EmailRemind70 { get; set; }

    public string? EmailRemind100 { get; set; }

    public string? EmailRemind90 { get; set; }

    public string? EmailRemind60 { get; set; }

    public string? EmailRemind30 { get; set; }

    public string? Location { get; set; }

    public string? Office { get; set; }

    public string? Zone { get; set; }

    public string? ForWebEmail { get; set; }

    public DateTime? ProjectExtension { get; set; }

    public long? Id { get; set; }

    public virtual ICollection<TraTrainee> TraTrainees { get; set; } = new List<TraTrainee>();
}
