using System;
using System.Collections.Generic;

namespace PAR.Infrastructure.Models;

public partial class Nrsachievementattachment
{
    public long NrsachievementId { get; set; }

    public long AttachmentsId { get; set; }

    public virtual Nrsattachment Attachments { get; set; } = null!;

    public virtual Nrsachievement Nrsachievement { get; set; } = null!;
}
