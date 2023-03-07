using System;
using System.Collections.Generic;

namespace MyApi1.Models;

public partial class Lcpmachinestatus1
{
    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Ip { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string? Unit { get; set; }

    public string? Basicpressure { get; set; }
}
