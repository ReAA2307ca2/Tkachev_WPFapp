using System;
using System.Collections.Generic;

namespace Tkachev_WPFapp.Models;

public partial class TechModel
{
    public int Id { get; set; }

    public string? Value { get; set; }

    public int? TechTypeId { get; set; }

    public virtual ICollection<Request> Requests { get; set; } = new List<Request>();

    public virtual TechType? TechType { get; set; }

    public override string ToString()
    {
        return this.Value;
    }
}
