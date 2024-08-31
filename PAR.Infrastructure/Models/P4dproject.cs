using System;
using System.Collections.Generic;

namespace PAR.Infrastructure.Models;

public partial class P4dproject
{
    public long Id { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? DateCreated { get; set; }

    public string? IpgNarrative { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string? LastUpdatedBy { get; set; }

    public string? Narrative { get; set; }

    public string? P4DoutputsNarrative { get; set; }

    public string? PartnersNarrative { get; set; }

    public string? Title { get; set; }

    public int Version { get; set; }

    public int Year { get; set; }

    public long MtpDocumentId { get; set; }

    public virtual P4dmtpdocument MtpDocument { get; set; } = null!;

    public virtual ICollection<P4doutput> P4doutputs { get; set; } = new List<P4doutput>();
}
