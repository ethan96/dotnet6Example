using System;
using System.Collections.Generic;

namespace MyApi1.Models;

public partial class Unitdefect1
{
    public Guid Id { get; set; }

    public string? Traceid { get; set; }

    public string? Repairtraceid { get; set; }

    public string Unitsn { get; set; } = null!;

    public string Defectcode { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string? Pic { get; set; }

    public string? Remark { get; set; }

    public string? Testlogpath { get; set; }

    public string? Donewc { get; set; }

    public string Wc { get; set; } = null!;

    public string Terminalcode { get; set; } = null!;

    public string? Repairer { get; set; }

    public string? Opid { get; set; }

    public DateTime Cdt { get; set; }

    public DateTime Udt { get; set; }
}
