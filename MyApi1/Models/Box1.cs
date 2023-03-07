using System;
using System.Collections.Generic;

namespace MyApi1.Models;

public partial class Box1
{
    public string Boxno { get; set; } = null!;

    public string Modelcode { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string? Partstatus { get; set; }

    public int Qty { get; set; }

    public int Packqty { get; set; }

    public bool Inspecting { get; set; }

    public string Linecode { get; set; } = null!;

    public string? Cartoncode { get; set; }

    public string? Units { get; set; }

    public string? Opid { get; set; }

    public DateTime Cdt { get; set; }

    public DateTime Udt { get; set; }
}
