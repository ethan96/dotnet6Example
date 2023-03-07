using System;
using System.Collections.Generic;

namespace MyApi1.Models;

public partial class Decision
{
    public string Code { get; set; } = null!;

    public string Category { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Project { get; set; }

    public string? Customer { get; set; }

    public string? Description { get; set; }

    public string? Rev { get; set; }

    public string? Status { get; set; }

    public string? Stage { get; set; }

    public string? Content { get; set; }

    public string? Param { get; set; }

    public DateTime Udt { get; set; }
}
