using System;
using System.Collections.Generic;

namespace MyApi1.Models;

public partial class Unitlog1
{
    public Guid Id { get; set; }

    public string? Traceid { get; set; }

    public string Unitsn { get; set; } = null!;

    public string Transaction { get; set; } = null!;

    public string? Detail { get; set; }

    public string Terminalcode { get; set; } = null!;

    public string Wc { get; set; } = null!;

    public int Result { get; set; }

    public string Inputtype { get; set; } = null!;

    public string? Opid { get; set; }

    public DateTime Cdt { get; set; }
}
