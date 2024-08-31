using System;
using System.Collections.Generic;

namespace PAR.Infrastructure.Models;

public partial class Programmember
{
    public long Program { get; set; }

    public long Member { get; set; }

    public virtual User MemberNavigation { get; set; } = null!;

    public virtual Program ProgramNavigation { get; set; } = null!;
}
