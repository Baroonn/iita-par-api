using System;
using System.Collections.Generic;

namespace PAR.Infrastructure.Models;

public partial class P4dcrp
{
    public long Id { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string? LastUpdatedBy { get; set; }

    public string? Title { get; set; }

    public int Version { get; set; }
}
