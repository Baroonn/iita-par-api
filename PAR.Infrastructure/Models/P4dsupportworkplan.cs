﻿using System;
using System.Collections.Generic;

namespace PAR.Infrastructure.Models;

public partial class P4dsupportworkplan
{
    public long Id { get; set; }

    public DateTime? DateCreated { get; set; }

    public DateTime? DateUpdated { get; set; }

    public string? Indicators { get; set; }

    public string? Objective { get; set; }

    public int? Status { get; set; }

    public int Version { get; set; }

    public int? Year { get; set; }

    public long UserId { get; set; }

    public virtual User User { get; set; } = null!;
}