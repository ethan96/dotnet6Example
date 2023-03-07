using System;
using System.Collections.Generic;

namespace MyApi1.Models;

public partial class Postatus
{
    public string Code { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string? Printstatus { get; set; }

    public string? Process { get; set; }

    public string? Base { get; set; }

    public DateTime Cdt { get; set; }

    public DateTime Udt { get; set; }
}
