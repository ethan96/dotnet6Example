using System;
using System.Collections.Generic;

namespace MyApi1.Models;

public partial class Releaseorder
{
    public string Code { get; set; } = null!;

    public string? Driver { get; set; }

    public string? Truckid { get; set; }

    public string? Trucktype { get; set; }

    public string? Terminalcode { get; set; }

    public string? Opid { get; set; }

    public DateTime Cdt { get; set; }

    public DateTime Udt { get; set; }
}
