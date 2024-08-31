using System;
using System.Collections.Generic;

namespace PAR.Infrastructure.Models;

public partial class Country
{
    public long Id { get; set; }

    public int Version { get; set; }

    public string? IsoCode { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Appraisal> Appraisals { get; set; } = new List<Appraisal>();
}
