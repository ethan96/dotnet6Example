using System;
using System.Collections.Generic;

namespace MyApi1.Models;

public partial class Dn1
{
    public string Code { get; set; } = null!;

    public string? Process { get; set; }

    public bool Ishold { get; set; }

    public string Status { get; set; } = null!;

    public string? Terminalcode { get; set; }

    public string? Opid { get; set; }

    public DateTime Cdt { get; set; }

    public DateTime Udt { get; set; }
}
