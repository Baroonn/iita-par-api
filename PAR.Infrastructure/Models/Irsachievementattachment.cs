using System;
using System.Collections.Generic;

namespace PAR.Infrastructure.Models;

public partial class Irsachievementattachment
{
    public long IrsachievementId { get; set; }

    public long AttachmentsId { get; set; }

    public virtual Attachment Attachments { get; set; } = null!;

    public virtual Irsachievement Irsachievement { get; set; } = null!;
}
