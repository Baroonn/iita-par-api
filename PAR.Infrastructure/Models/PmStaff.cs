using System;
using System.Collections.Generic;

namespace PAR.Infrastructure.Models;

public partial class PmStaff
{
    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Position { get; set; }

    public string? Status { get; set; }

    public string? Email { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? Nationality { get; set; }

    public string? Location { get; set; }

    public string? Classification { get; set; }

    public string? Institution { get; set; }

    public string? StaffStatus { get; set; }

    public string? Category { get; set; }

    public string? CategoryType { get; set; }

    public long? Iitauserid { get; set; }

    public long PersonId { get; set; }

    public virtual User? Iitauser { get; set; }

    public virtual ICollection<PmIdeastaff> PmIdeastaffs { get; set; } = new List<PmIdeastaff>();
}
