using System;
using System.Collections.Generic;

namespace PAR.Infrastructure.Models;

public partial class PmTechnicalreport
{
    public long Id { get; set; }

    public string? Project { get; set; }

    public double? TechRepId { get; set; }

    public DateTime? ReportDate { get; set; }

    public DateTime? DeliveryDate { get; set; }

    public DateTime? PeriodFrom { get; set; }

    public DateTime? PeriodTo { get; set; }

    public string? Donor { get; set; }

    public string? Partner { get; set; }

    public string? Comments { get; set; }

    public string? DelayReason { get; set; }

    public string? Type { get; set; }

    public string? EmailRemind { get; set; }

    public long? ProjectId { get; set; }
}
