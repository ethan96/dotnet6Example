using System;
using System.Collections.Generic;

namespace MyApi1.Models;

public partial class Terminal
{
    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Linecode { get; set; }

    public string? Line { get; set; }

    public string? Setting { get; set; }

    public DateTime Udt { get; set; }
}
