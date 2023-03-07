using System;
using System.Collections.Generic;

namespace MyApi1.Models;

public partial class Snseq
{
    public Guid Id { get; set; }

    public string Type { get; set; } = null!;

    public string Prefix { get; set; } = null!;

    public string Seq { get; set; } = null!;

    public DateTime Cdt { get; set; }

    public DateTime Udt { get; set; }
}
