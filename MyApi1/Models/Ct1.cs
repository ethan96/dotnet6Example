using System;
using System.Collections.Generic;

namespace MyApi1.Models;

public partial class Ct1
{
    public string Ctsn { get; set; } = null!;

    public string Pocode { get; set; } = null!;

    public string Commodity { get; set; } = null!;

    public string Pn { get; set; } = null!;

    public string? Sparepn { get; set; }

    public string? Supplier { get; set; }

    public string? Warrantycode { get; set; }

    public string Status { get; set; } = null!;

    public string Terminalcode { get; set; } = null!;

    public string? Opid { get; set; }

    public DateTime Cdt { get; set; }
}
