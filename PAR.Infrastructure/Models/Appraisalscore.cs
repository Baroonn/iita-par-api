using System;
using System.Collections.Generic;

namespace PAR.Infrastructure.Models;

public partial class Appraisalscore
{
    public long Id { get; set; }

    public string? ScoreKey { get; set; }

    public float Score { get; set; }

    public long AppraisalId { get; set; }

    public virtual Appraisal Appraisal { get; set; } = null!;
}
