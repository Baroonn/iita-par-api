using System;
using System.Collections.Generic;

namespace PAR.Infrastructure.Models;

public partial class Travelauthorization
{
    public long Id { get; set; }

    public int Version { get; set; }

    public string? CostSharing { get; set; }

    public DateTime DateCreated { get; set; }

    public DateTime DateModifed { get; set; }

    public string? Description { get; set; }

    public DateTime? EndDate { get; set; }

    public string? Funding { get; set; }

    public string? OracleRequisitionNumber { get; set; }

    public DateTime? StartDate { get; set; }

    public int Status { get; set; }

    public string? Title { get; set; }

    public double? TotalCost { get; set; }

    public string? TripType { get; set; }

    public long? LineManagerId { get; set; }

    public long OwnerId { get; set; }

    public long? TravelerId { get; set; }
}
