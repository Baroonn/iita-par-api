using System;
using System.Collections.Generic;

namespace PAR.Infrastructure.Models;

public partial class Notification
{
    public long Id { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string? LastUpdatedBy { get; set; }

    public string? Message { get; set; }

    public string? OriginAppName { get; set; }

    public ulong? Read { get; set; }

    public string? Title { get; set; }

    public long? SubscriberNotificationId { get; set; }

    public virtual User? SubscriberNotification { get; set; }
}
