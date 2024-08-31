using System;
using System.Collections.Generic;

namespace PAR.Infrastructure.Models;

public partial class P4dsupportachievementattachment
{
    public long P4dsupportAchievementId { get; set; }

    public long AttachmentsId { get; set; }

    public virtual P4dsupportattachment Attachments { get; set; } = null!;

    public virtual P4dsupportachievement P4dsupportAchievement { get; set; } = null!;
}
