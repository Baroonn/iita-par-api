using System;
using System.Collections.Generic;

namespace PAR.Infrastructure.Models;

public partial class PmProjectstaff
{
    public long Id { get; set; }

    public string? Project { get; set; }

    public string? Carnet { get; set; }

    public int? Participation { get; set; }

    public string? Leader { get; set; }

    public string? ProjectPosition { get; set; }

    public DateTime? PjStartDate { get; set; }

    public DateTime? PjEndDate { get; set; }

    public long? ProjectId { get; set; }

    public long? PersonId { get; set; }
}
