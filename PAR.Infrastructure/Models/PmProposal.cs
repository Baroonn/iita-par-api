using System;
using System.Collections.Generic;

namespace PAR.Infrastructure.Models;

public partial class PmProposal
{
    public string Proposal { get; set; } = null!;

    public string? Idea { get; set; }

    public string? Project { get; set; }

    public string? Macroproject { get; set; }

    public string? Title { get; set; }

    public string? ResearchSite { get; set; }

    public int? Duration { get; set; }

    public DateTime? Submission { get; set; }

    public int? ExpectedYear { get; set; }

    public string? Remarks { get; set; }

    public string? Status { get; set; }

    public long? TotalBudget { get; set; }

    public long? CiatBudget { get; set; }

    public DateTime? ContractDate { get; set; }

    public string? RejectionReason { get; set; }

    public string? Goal { get; set; }

    public string? Purpose { get; set; }

    public string? Description { get; set; }

    public string? ExpectedResult { get; set; }

    public string? PotentialBeneficiaries { get; set; }

    public string? DonorReply { get; set; }

    public string? EmailRemind { get; set; }

    public string? Topic { get; set; }

    public string? Discipline { get; set; }

    public string? Crop { get; set; }

    public DateTime? ResponseDate { get; set; }

    public string? ContactEmail { get; set; }

    public long Id { get; set; }

    public virtual ICollection<PmProposalstaff> PmProposalstaffs { get; set; } = new List<PmProposalstaff>();
}
