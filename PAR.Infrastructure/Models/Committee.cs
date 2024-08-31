using System;
using System.Collections.Generic;

namespace PAR.Infrastructure.Models;

public partial class Committee
{
    public long Id { get; set; }

    public int Version { get; set; }

    public string? Chair { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Appraisalcommittee> Appraisalcommittees { get; set; } = new List<Appraisalcommittee>();
}
