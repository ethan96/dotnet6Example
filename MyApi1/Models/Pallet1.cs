using System;
using System.Collections.Generic;

namespace MyApi1.Models;

public partial class Pallet1
{
    public string Code { get; set; } = null!;

    public string? Base { get; set; }

    public double? Weight { get; set; }

    public string? Dimension { get; set; }

    public string Status { get; set; } = null!;

    public string? Terminalcode { get; set; }

    public string? Opid { get; set; }

    public DateTime Cdt { get; set; }

    public DateTime Udt { get; set; }
}
