using System;
using System.Collections.Generic;

namespace MyApi1.Models;

public partial class Setting
{
    public string Datatype { get; set; } = null!;

    public string? Content { get; set; }

    public DateTime Udt { get; set; }
}
