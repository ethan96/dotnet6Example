using System;
using System.Collections.Generic;

namespace MyApi1.Models;

public partial class Unit
{
    public string Sn { get; set; } = null!;

    public string Pocode { get; set; } = null!;

    public int Index { get; set; }

    public string Runtime { get; set; } = null!;

    public string? Attribute { get; set; }

    public string Type { get; set; } = null!;

    public string? Boxno { get; set; }

    public string? Dncode { get; set; }

    public string? Cartoncode { get; set; }

    public string? Child { get; set; }

    public string? Parent { get; set; }

    public string? Opid { get; set; }

    public DateTime Cdt { get; set; }

    public DateTime Udt { get; set; }

    public string? Custattribute { get; set; }
}
