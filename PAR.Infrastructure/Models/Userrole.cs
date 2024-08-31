using System;
using System.Collections.Generic;

namespace PAR.Infrastructure.Models;

/// <summary>
/// User roles
/// </summary>
public partial class Userrole
{
    public long Id { get; set; }

    public string Application { get; set; } = null!;

    public long UserId { get; set; }

    public string Role { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
