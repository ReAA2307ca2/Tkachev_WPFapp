using System;
using System.Collections.Generic;

namespace Tkachev_WPFapp.Models;

public partial class TechType
{
    public int Id { get; set; }

    public string? Value { get; set; }

    public virtual ICollection<TechModel> TechModels { get; set; } = new List<TechModel>();
}
