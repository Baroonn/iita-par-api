using System;
using System.Collections.Generic;

namespace PAR.Infrastructure.Models;

public partial class Learningattachment1
{
    public long LearningId { get; set; }

    public long AttachmentsId { get; set; }

    public virtual Learningattachment Attachments { get; set; } = null!;

    public virtual Learning Learning { get; set; } = null!;
}
