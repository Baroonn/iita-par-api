using System;
using System.Collections.Generic;

namespace PAR.Infrastructure.Models;

/// <summary>
/// User hierarchy
/// </summary>
public partial class Usersupervisor
{
    public long Id { get; set; }

    public string Application { get; set; } = null!;

    public long UserId { get; set; }

    public long SupervisorId { get; set; }

    public virtual User Supervisor { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
