using System;
using System.Collections.Generic;

namespace PAR.Infrastructure.Models;

public partial class Staffcommentlog
{
    public long Id { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string? LastUpdatedBy { get; set; }

    public int Version { get; set; }

    public string? Comment { get; set; }

    public DateTime? SysDate { get; set; }

    public string? Username { get; set; }

    public long AppraisalId { get; set; }

    public long? UserId { get; set; }

    public virtual Appraisal Appraisal { get; set; } = null!;

    public virtual User? User { get; set; }
}
