using System;
using System.Collections.Generic;

namespace MyApi1.Models;

public partial class Boxpart1
{
    public Guid Id { get; set; }

    public string? Traceid { get; set; }

    public string Boxno { get; set; } = null!;

    public string Pn { get; set; } = null!;

    public string Scanpn { get; set; } = null!;

    public string Partsn { get; set; } = null!;

    public string Parttype { get; set; } = null!;

    public string? Commodity { get; set; }

    public string Location { get; set; } = null!;

    public string? Action { get; set; }

    public string Wc { get; set; } = null!;

    public string Terminalcode { get; set; } = null!;

    public string Remark { get; set; } = null!;

    public string? Info { get; set; }

    public string? Attribute { get; set; }

    public string? Opid { get; set; }

    public DateTime Cdt { get; set; }
}
