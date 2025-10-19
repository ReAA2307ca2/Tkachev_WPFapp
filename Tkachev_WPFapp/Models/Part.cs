using System;
using System.Collections.Generic;

namespace Tkachev_WPFapp.Models;

public partial class Part
{
    public int Id { get; set; }

    public string? Value { get; set; }

    public virtual ICollection<RequestsPart> RequestsParts { get; set; } = new List<RequestsPart>();
}
