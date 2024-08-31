using System;
using System.Collections.Generic;

namespace PAR.Infrastructure.Models;

public partial class Useraccesstag
{
    public long UserId { get; set; }

    public string Tag { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
