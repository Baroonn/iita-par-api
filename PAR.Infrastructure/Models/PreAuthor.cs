﻿using System;
using System.Collections.Generic;

namespace PAR.Infrastructure.Models;

public partial class PreAuthor
{
    public int? Id { get; set; }

    public string? Surname { get; set; }

    public string? Von { get; set; }

    public string? Firstname { get; set; }

    public string? Email { get; set; }

    public string? Url { get; set; }

    public string? Institute { get; set; }

    public string? Cleanname { get; set; }

    public long? Iitauserid { get; set; }

    public virtual User? Iitauser { get; set; }
}