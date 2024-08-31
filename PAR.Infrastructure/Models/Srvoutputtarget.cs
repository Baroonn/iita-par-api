using System;
using System.Collections.Generic;

namespace PAR.Infrastructure.Models;

public partial class Srvoutputtarget
{
    public long Id { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? DateCreated { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string? LastUpdatedBy { get; set; }

    public string? Title { get; set; }

    public string? Types { get; set; }

    public int Version { get; set; }

    public int Year { get; set; }

    public long SrvoutputId { get; set; }
}
