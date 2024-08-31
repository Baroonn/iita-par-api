using System;
using System.Collections.Generic;

namespace PAR.Infrastructure.Models;

public partial class Achievementattachment
{
    public long AchievementId { get; set; }

    public long AttachmentsId { get; set; }

    public long? KpiachievementId { get; set; }

    public long? IrsKpiachievementId { get; set; }

    public virtual Irskpiachievement? IrsKpiachievement { get; set; }

    public virtual Kpiachievement? Kpiachievement { get; set; }
}
