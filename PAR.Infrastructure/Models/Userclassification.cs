using System;
using System.Collections.Generic;

namespace PAR.Infrastructure.Models;

public partial class Userclassification
{
    public long Id { get; set; }

    public int Version { get; set; }

    public string? Classification { get; set; }

    public int Pg { get; set; }

    public long UserId { get; set; }

    public int? Year { get; set; }

    public string? Jobdescription { get; set; }

    public string? Staffcategory { get; set; }

    public virtual User User { get; set; } = null!;
}
