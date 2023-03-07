using System;
using System.Collections.Generic;

namespace MyApi1.Models;

public partial class Seal1
{
    public string Code { get; set; } = null!;

    public string? Base { get; set; }

    public string? Gpsid { get; set; }

    public string? Truckid { get; set; }

    public string? Trucktype { get; set; }

    public string? Releaseordercode { get; set; }

    public string Status { get; set; } = null!;

    public string? Terminalcode { get; set; }

    public string? Opid { get; set; }

    public DateTime Cdt { get; set; }

    public DateTime Udt { get; set; }
}
