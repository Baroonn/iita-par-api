﻿using System;
using System.Collections.Generic;

namespace PAR.Infrastructure.Models;

public partial class Workplanstatuslog
{
    public long Id { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string? LastUpdatedBy { get; set; }

    public int Version { get; set; }

    public string? Action { get; set; }

    public string? Comment { get; set; }

    public DateTime? SysDate { get; set; }

    public string? Username { get; set; }

    public long? UserId { get; set; }

    public long WorkplanActionStatusId { get; set; }

    public virtual Workplanactionstatus WorkplanActionStatus { get; set; } = null!;
}
