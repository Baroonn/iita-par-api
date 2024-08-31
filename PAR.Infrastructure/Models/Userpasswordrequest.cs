using System;
using System.Collections.Generic;

namespace PAR.Infrastructure.Models;

public partial class Userpasswordrequest
{
    public long Id { get; set; }

    public long UserId { get; set; }

    public string Key { get; set; } = null!;

    public int Status { get; set; }

    public DateTime DateGenerated { get; set; }

    public DateTime? DateUsed { get; set; }

    public virtual User User { get; set; } = null!;
}
