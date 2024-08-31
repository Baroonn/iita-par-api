﻿using System;
using System.Collections.Generic;

namespace PAR.Infrastructure.Models;

public partial class Srvoutput
{
    public long Id { get; set; }

    public string? CgiarAlignment { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? DateCreated { get; set; }

    public string? Description { get; set; }

    public string? Impact { get; set; }

    public string? IntendedUser { get; set; }

    public string? IpgNarrative { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string? LastUpdatedBy { get; set; }

    public string? Outcome { get; set; }

    public string? PartnersNarrative { get; set; }

    public string? Title { get; set; }

    public int Version { get; set; }

    public long SrvprojectId { get; set; }
}
