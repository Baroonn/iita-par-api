using System;
using System.Collections.Generic;

namespace PAR.Infrastructure.Models;

/// <summary>
/// Delegations
/// </summary>
public partial class Userdelegation
{
    public long Id { get; set; }

    public string Application { get; set; } = null!;

    public long OwnerId { get; set; }

    public long DelegatedTo { get; set; }

    public DateTime? FromDate { get; set; }

    public DateTime? ToDate { get; set; }

    public virtual User DelegatedToNavigation { get; set; } = null!;

    public virtual User Owner { get; set; } = null!;
}
