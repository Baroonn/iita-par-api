using System;
using System.Collections.Generic;

namespace PAR.Infrastructure.Models;

public partial class Workplanactionstatus
{
    public long Id { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string? LastUpdatedBy { get; set; }

    public int Version { get; set; }

    public string? ApprovalStatus { get; set; }

    public string? SubmissionStatus { get; set; }

    public int? Year { get; set; }

    public long? AppraiseeId { get; set; }

    public long? AppraiserId { get; set; }

    public virtual User? Appraisee { get; set; }

    public virtual User? Appraiser { get; set; }

    public virtual ICollection<Workplanstatuslog> Workplanstatuslogs { get; set; } = new List<Workplanstatuslog>();
}
