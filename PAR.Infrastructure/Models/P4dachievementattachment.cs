using System;
using System.Collections.Generic;

namespace PAR.Infrastructure.Models;

public partial class P4dachievementattachment
{
    public long P4dachievementId { get; set; }

    public long AttachmentsId { get; set; }

    public virtual P4dattachment Attachments { get; set; } = null!;

    public virtual P4dachievement P4dachievement { get; set; } = null!;
}
