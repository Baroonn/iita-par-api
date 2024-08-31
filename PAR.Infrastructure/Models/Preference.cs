using System;
using System.Collections.Generic;

namespace PAR.Infrastructure.Models;

public partial class Preference
{
    public int PreferenceType { get; set; }

    public long Id { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string? LastUpdatedBy { get; set; }

    public string? Description { get; set; }

    public string? PreferenceKey { get; set; }

    public ulong? BoolVal { get; set; }

    public string? CharVal { get; set; }

    public double? DoubleVal { get; set; }

    public long? LongVal { get; set; }

    public string? StringVal { get; set; }

    public int? IntVal { get; set; }

    public decimal? BigVal { get; set; }

    public DateTime? DateVal { get; set; }

    public long? UserId { get; set; }

    public virtual User? User { get; set; }
}
