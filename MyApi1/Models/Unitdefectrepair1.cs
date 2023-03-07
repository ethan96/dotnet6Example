using System;
using System.Collections.Generic;

namespace MyApi1.Models;

public partial class Unitdefectrepair1
{
    public Guid Id { get; set; }

    public Guid Defectid { get; set; }

    public string Defectcode { get; set; } = null!;

    public string Causecode { get; set; } = null!;

    public string Commodity { get; set; } = null!;

    public string? Subcommodity { get; set; }

    public string Repairaction { get; set; } = null!;

    public string Failpn { get; set; } = null!;

    public string? Failsno { get; set; }

    public string? Newpn { get; set; }

    public string? Newsno { get; set; }

    public string? Location { get; set; }

    public string? Partattribute { get; set; }

    public string? Unbind { get; set; }

    public bool? Isfaultypart { get; set; }

    public string? Remark { get; set; }

    public string? Rootcause { get; set; }

    public string? Correctiveaction { get; set; }

    public string? Donewc { get; set; }

    public string Status { get; set; } = null!;

    public string? Opid { get; set; }

    public DateTime Cdt { get; set; }

    public DateTime Udt { get; set; }
}
