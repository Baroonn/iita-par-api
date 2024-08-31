using System;
using System.Collections.Generic;

namespace PAR.Infrastructure.Models;

public partial class Userlookup
{
    public long Id { get; set; }

    public string Identifier { get; set; } = null!;

    public long Userid { get; set; }
}
