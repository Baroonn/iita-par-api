using System;
using System.Collections.Generic;

namespace PAR.Infrastructure.Models;

public partial class PmCostcenter
{
    public long Id { get; set; }

    public string? CcCode { get; set; }

    public double? Year { get; set; }

    public double? Budget { get; set; }

    public double? ActualExp { get; set; }

    public double? Encumb { get; set; }

    public double? OtherInc { get; set; }

    public double? Rcpts { get; set; }

    public DateTime? RefreshDate { get; set; }
}
