using System;
using System.Collections.Generic;

namespace PAR.Infrastructure.Models;

public partial class Traveler
{
    public long Id { get; set; }

    public int Version { get; set; }

    public string? Email { get; set; }

    public DateTime? EndDate { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? StaffId { get; set; }

    public DateTime? StartDate { get; set; }

    public long TravelAuthorizationId { get; set; }

    public long? UserId { get; set; }
}
