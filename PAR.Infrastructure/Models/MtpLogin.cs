using System;
using System.Collections.Generic;

namespace PAR.Infrastructure.Models;

public partial class MtpLogin
{
    public long? Id { get; set; }

    public string? Staffname { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }

    public string? Firstname { get; set; }

    public string? Lastname { get; set; }

    public long? Iitauserid { get; set; }
}
