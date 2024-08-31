using System;
using System.Collections.Generic;

namespace PAR.Infrastructure.Models;

public partial class PrePublicationauthor
{
    public long Id { get; set; }

    public int? PubId { get; set; }

    public int? Author { get; set; }

    public int? Rank { get; set; }

    public string? IsEditor { get; set; }

    public virtual PrePublication? Pub { get; set; }
}
