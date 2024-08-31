using System;
using System.Collections.Generic;

namespace PAR.Infrastructure.Models;

public partial class PmProjectcostcenter
{
    public long Id { get; set; }

    public double? PdId { get; set; }

    public string? Project { get; set; }

    public string? Donor { get; set; }

    public double? DonorContribution { get; set; }

    public string? Remarks { get; set; }

    public double? OriginalCurrency { get; set; }

    public string? Currency { get; set; }

    public string? Relationship { get; set; }

    public double? Rate { get; set; }

    public double? SrcToAgency { get; set; }

    public string? IitaCc { get; set; }
}
