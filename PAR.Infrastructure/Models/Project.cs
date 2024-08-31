using System;
using System.Collections.Generic;

namespace PAR.Infrastructure.Models;

public partial class Project
{
    public long Id { get; set; }

    public DateTime? DateCreated { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string? LastUpdatedBy { get; set; }

    public string? Title { get; set; }

    public int Version { get; set; }

    public int Year { get; set; }

    public string? IpgNarrative { get; set; }

    public string? Narrative { get; set; }

    public string? OutputsNarrative { get; set; }

    public string? PartnersNarrative { get; set; }

    public long? MtpDocumentId { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public virtual Mtpdocument? MtpDocument { get; set; }

    public virtual ICollection<Output> Outputs { get; set; } = new List<Output>();
}
