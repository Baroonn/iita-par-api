using System;
using System.Collections.Generic;

namespace PAR.Infrastructure.Models;

public partial class PmProposalstaff
{
    public string? Proposal { get; set; }

    public string? Carnet { get; set; }

    public int? Participation { get; set; }

    public string? Leader { get; set; }

    public long Id { get; set; }

    public long? ProposalId { get; set; }

    public long? PersonId { get; set; }

    public virtual PmProposal? ProposalNavigation { get; set; }
}
