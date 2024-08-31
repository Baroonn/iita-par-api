using System;
using System.Collections.Generic;

namespace PAR.Infrastructure.Models;

public partial class Irskpi
{
    public long Id { get; set; }

    public string? Activity { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? DateCreated { get; set; }

    public string? Kpitext { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string? LastUpdatedBy { get; set; }

    public string? MileStoneQtr1 { get; set; }

    public string? MileStoneQtr2 { get; set; }

    public string? MileStoneQtr3 { get; set; }

    public string? MileStoneQtr4 { get; set; }

    public int Version { get; set; }

    public long? WorkplanId { get; set; }

    public virtual ICollection<Irskpiachievement> Irskpiachievements { get; set; } = new List<Irskpiachievement>();

    public virtual Irsworkplan? Workplan { get; set; }
}
