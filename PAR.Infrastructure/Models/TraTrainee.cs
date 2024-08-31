using System;
using System.Collections.Generic;

namespace PAR.Infrastructure.Models;

public partial class TraTrainee
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public string? Country { get; set; }

    public string? Gender { get; set; }

    public string? Degree { get; set; }

    public string? Location { get; set; }

    public string? SponsorType { get; set; }

    public string? University { get; set; }

    public string? Sponsors { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? RegStatus { get; set; }

    public string? Program { get; set; }

    public string? ResearchTopic { get; set; }

    public string? Supervisor { get; set; }

    public long? Iitauserid { get; set; }

    public string? Email { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime LastUpdated { get; set; }

    public string LastUpdatedBy { get; set; } = null!;

    public string? CurrentAddress { get; set; }

    public string? PermanentAddress { get; set; }

    public string? Phone { get; set; }

    public string? UniversityAddress { get; set; }

    public string? UniversitySupervisor { get; set; }

    public string? UniversitySupervisorEmail { get; set; }

    public string? UniversitySupervisorPhone { get; set; }

    public DateTime? ExtensionDate { get; set; }

    public string? CostCenter { get; set; }

    public string? ProjectNo { get; set; }

    public string? ProgramProject { get; set; }

    public DateTime? DegreeAwardDate { get; set; }

    public string? PresentEmployerName { get; set; }

    public string? PresentEmployerAddress { get; set; }

    public virtual User? Iitauser { get; set; }

    public virtual PmProject? ProgramProjectNavigation { get; set; }
}
