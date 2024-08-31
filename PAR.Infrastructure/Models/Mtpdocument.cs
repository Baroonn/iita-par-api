using System;
using System.Collections.Generic;

namespace PAR.Infrastructure.Models;

public partial class Mtpdocument
{
    public long Id { get; set; }

    public DateTime? DateCreated { get; set; }

    public int EndYear { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string? LastUpdatedBy { get; set; }

    public string? Narrative { get; set; }

    public int StartYear { get; set; }

    public string? Title { get; set; }

    public int Version { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public virtual ICollection<Project> Projects { get; set; } = new List<Project>();
}
