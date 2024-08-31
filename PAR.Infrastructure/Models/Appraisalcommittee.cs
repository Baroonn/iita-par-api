﻿using System;
using System.Collections.Generic;

namespace PAR.Infrastructure.Models;

public partial class Appraisalcommittee
{
    public long Id { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string? LastUpdatedBy { get; set; }

    public int Version { get; set; }

    public long? AppraisalId { get; set; }

    public long? CommitteeId { get; set; }

    public virtual Appraisal? Appraisal { get; set; }

    public virtual Committee? Committee { get; set; }
}
