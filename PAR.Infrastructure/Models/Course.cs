using System;
using System.Collections.Generic;

namespace PAR.Infrastructure.Models;

public partial class Course
{
    public long Id { get; set; }

    public int Version { get; set; }

    public string? Name { get; set; }

    public long? Year { get; set; }
}
