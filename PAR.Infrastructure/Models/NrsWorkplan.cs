using System;
using System.Collections.Generic;

namespace PAR.Infrastructure.Models;

/// <summary>
/// NRS Workplan
/// </summary>
public partial class NrsWorkplan
{
    public long Id { get; set; }

    public long UserId { get; set; }

    public int Year { get; set; }

    public DateTime DateCreated { get; set; }

    public DateTime DateUpdated { get; set; }

    public int Version { get; set; }

    public int Status { get; set; }

    public string Objective { get; set; } = null!;

    public string Indicators { get; set; } = null!;

    public virtual ICollection<Kpi> Kpis { get; set; } = new List<Kpi>();

    public virtual ICollection<Nrsachievement> Nrsachievements { get; set; } = new List<Nrsachievement>();

    public virtual User User { get; set; } = null!;
}
