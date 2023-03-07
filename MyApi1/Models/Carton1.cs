using System;
using System.Collections.Generic;

namespace MyApi1.Models;

public partial class Carton1
{
    public string Code { get; set; } = null!;

    public string? Base { get; set; }

    public string? Boxno { get; set; }

    public string? Midbox { get; set; }

    public string? Innerbox { get; set; }

    public bool Inspecting { get; set; }

    public string Status { get; set; } = null!;

    public string? Terminalcode { get; set; }

    public string? Opid { get; set; }

    public DateTime Cdt { get; set; }

    public DateTime Udt { get; set; }
}
