using System;
using System.Collections.Generic;

namespace PAR.Infrastructure.Models;

public partial class Srvachievement
{
    public long Id { get; set; }

    public string? Achievement { get; set; }

    public string? Completion { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? DateCreated { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string? LastUpdatedBy { get; set; }

    public int Version { get; set; }

    public long ActivityId { get; set; }
}
