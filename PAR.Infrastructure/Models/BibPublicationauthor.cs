using System;
using System.Collections.Generic;

namespace PAR.Infrastructure.Models;

/// <summary>
/// InnoDB free: 4096 kB
/// </summary>
public partial class BibPublicationauthor
{
    public int PubId { get; set; }

    public int Author { get; set; }

    public int? Rank { get; set; }

    public string IsEditor { get; set; } = null!;

    public virtual BibAuthor AuthorNavigation { get; set; } = null!;

    public virtual BibPublication Pub { get; set; } = null!;
}
