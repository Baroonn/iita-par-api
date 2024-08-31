using System;
using System.Collections.Generic;

namespace PAR.Infrastructure.Models;

public partial class PmProjectdocument
{
    public long Id { get; set; }

    public string? Project { get; set; }

    public string? Type { get; set; }

    public double? RepId { get; set; }

    public string? Document { get; set; }

    public string? UploadedBy { get; set; }

    public DateTime? UploadedOn { get; set; }

    public double? Version { get; set; }

    public string? Title { get; set; }
}
