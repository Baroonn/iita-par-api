using System;
using System.Collections.Generic;

namespace PAR.Infrastructure.Models;

public partial class Program
{
    public long Id { get; set; }

    public int Version { get; set; }

    public string? Description { get; set; }

    public int? Status { get; set; }

    public string? Title { get; set; }

    public long? Director { get; set; }

    public virtual User? DirectorNavigation { get; set; }
}
