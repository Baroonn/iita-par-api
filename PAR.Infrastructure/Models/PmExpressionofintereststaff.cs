using System;
using System.Collections.Generic;

namespace PAR.Infrastructure.Models;

public partial class PmExpressionofintereststaff
{
    public uint Id { get; set; }

    public string? Idea { get; set; }

    public string? Carnet { get; set; }

    public string? Leader { get; set; }

    public int? Participation { get; set; }

    public long? PersonId { get; set; }

    public long? IdeaId { get; set; }
}
