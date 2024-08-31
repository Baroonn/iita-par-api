using System;
using System.Collections.Generic;

namespace PAR.Infrastructure.Models;

public partial class Learningattachment
{
    public long Id { get; set; }

    public int Version { get; set; }

    public string? ContentType { get; set; }

    public DateTime? DateCreated { get; set; }

    public string DiskPath { get; set; } = null!;

    public long Downloads { get; set; }

    public string? FileName { get; set; }

    public string? Title { get; set; }
}
