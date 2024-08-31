using System;
using System.Collections.Generic;

namespace PAR.Infrastructure.Models;

public partial class PmCorebudget
{
    public long Id { get; set; }

    public string? CcCode { get; set; }

    public string? CcDescr { get; set; }

    public string? CcStatus { get; set; }

    public double? CcBudgetYtd { get; set; }

    public double? CcExpYtd { get; set; }

    public double? CcEncYtd { get; set; }

    public double? CcPcentExp { get; set; }

    public double? CcFundsAvail { get; set; }

    public DateTime? RefreshDate { get; set; }

    public string? EmailRemind { get; set; }

    public string? Email { get; set; }

    public long? Iitauserid { get; set; }

    public virtual User? Iitauser { get; set; }
}
