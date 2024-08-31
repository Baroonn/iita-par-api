using System;
using System.Collections.Generic;

namespace PAR.Infrastructure.Models;

public partial class Usernotification
{
    public long Id { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string? LastUpdatedBy { get; set; }

    public int Version { get; set; }

    public string EventName { get; set; } = null!;

    public string? FormatString { get; set; }

    public string? Frequency { get; set; }

    public string? Priority { get; set; }

    public ulong Subscribed { get; set; }

    public long UserId { get; set; }

    public virtual User User { get; set; } = null!;
}
