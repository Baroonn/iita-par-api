using System;
using System.Collections.Generic;

namespace PAR.Infrastructure.Models;

public partial class PmPartner
{
    public long Id { get; set; }

    public string? Partner { get; set; }

    public string? Acronym { get; set; }

    public string? Name { get; set; }

    public string? Address { get; set; }

    public string? Postal { get; set; }

    public string? Country { get; set; }

    public string? Email { get; set; }

    public string? Telephone { get; set; }

    public string? Fax { get; set; }

    public int? ProposalIndicator { get; set; }

    public int? ProjectIndicator { get; set; }

    public string? PartnerType { get; set; }

    public string? DonorCat { get; set; }

    public string? PartnerSince { get; set; }

    public string? Partnersite { get; set; }

    public string? Cgiar { get; set; }

    public string? Geogscope { get; set; }

    public string? FoundingYear { get; set; }

    public string? AreasOfOperation { get; set; }

    public string? AlreadyPartner { get; set; }

    public string? PartnershipType { get; set; }
}
