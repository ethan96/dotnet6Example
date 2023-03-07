using System;
using System.Collections.Generic;

namespace MyApi1.Models;

public partial class Printlog
{
    public Guid Id { get; set; }

    public string Labeltype { get; set; } = null!;

    public string Labelid { get; set; } = null!;

    public string? Key { get; set; }

    public string? Keytype { get; set; }

    public string? Dn { get; set; }

    public string? Input { get; set; }

    public string? Output { get; set; }

    public bool Isreprint { get; set; }

    public string? Terminalcode { get; set; }

    public string? Wc { get; set; }

    public string? Opid { get; set; }

    public DateTime Cdt { get; set; }
}
