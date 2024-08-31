using System;
using System.Collections.Generic;

namespace PAR.Infrastructure.Models;

public partial class MtpAchievement
{
    public long Id { get; set; }

    public long? Mtprecid { get; set; }

    public int? Activitynum { get; set; }

    public string? Achievement { get; set; }

    public long? Completion { get; set; }

    public long? Weight { get; set; }

    public string? Comment { get; set; }

    public DateTime? Regdate { get; set; }

    public string? FileEvidence { get; set; }
}
