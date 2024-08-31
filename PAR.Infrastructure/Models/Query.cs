using System;
using System.Collections.Generic;

namespace PAR.Infrastructure.Models;

public partial class Query
{
    public long Id { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string? LastUpdatedBy { get; set; }

    public int Version { get; set; }

    public string? Description { get; set; }

    public string? Heads { get; set; }

    public string? Query1 { get; set; }

    public string? ShortName { get; set; }

    public string? Title { get; set; }

    public string? AllowedRoles { get; set; }

    public string? TemplateName { get; set; }

    public virtual ICollection<Queryparameter> Queryparameters { get; set; } = new List<Queryparameter>();
}
