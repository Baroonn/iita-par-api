﻿using System;
using System.Collections.Generic;

namespace PAR.Infrastructure.Models;

public partial class Srvactivity
{
    public long Id { get; set; }

    public string? Activity { get; set; }

    public string? AllocatedTime { get; set; }

    public string? CoreCenter { get; set; }

    public string? CostCenter { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CrpPartners { get; set; }

    public DateTime? DateCreated { get; set; }

    public string? InternalIita { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string? LastUpdatedBy { get; set; }

    public string? MileStoneQtr1 { get; set; }

    public string? MileStoneQtr2 { get; set; }

    public string? MileStoneQtr3 { get; set; }

    public string? MileStoneQtr4 { get; set; }

    public string? OtherExternal { get; set; }

    public double? ProposedBudget { get; set; }

    public int Version { get; set; }

    public long? WorkplanId { get; set; }
}
