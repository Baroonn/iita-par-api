using System;
using System.Collections.Generic;

namespace PAR.Infrastructure.Models;

public partial class Queryparameter
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public long? QueryId { get; set; }

    public virtual Query? Query { get; set; }
}
