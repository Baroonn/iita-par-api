using System;
using System.Collections.Generic;

namespace PAR.Infrastructure.Models;

public partial class ParWorkplan
{
    public long Id { get; set; }

    public int Version { get; set; }

    public string? Qtysc { get; set; }

    public string? Com { get; set; }

    public string? ResponseCall { get; set; }

    public string? OtherResources { get; set; }

    public string? StaffSupervised { get; set; }

    public string? MgtRole { get; set; }

    public string? Otherprof { get; set; }

    public string? CareerDevelopmentNeed { get; set; }

    public int ActivityYear { get; set; }

    public long User { get; set; }

    public string? ManagedProjects { get; set; }

    public string? ProjectParticipation { get; set; }

    public string? ProjectProposal { get; set; }

    public string? ConceptNote { get; set; }

    public string? Travel { get; set; }

    public string? Bibliography { get; set; }

    public string? PrePublishedMaterial { get; set; }

    public string? TrainingPrograms { get; set; }

    public string? Trainees { get; set; }
}
