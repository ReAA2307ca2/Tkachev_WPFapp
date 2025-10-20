using System;
using System.Collections.Generic;

namespace Tkachev_WPFapp.Models;

public partial class RequestPart
{
    public int Id { get; set; }

    public int? RequestId { get; set; }

    public int? PartId { get; set; }

    public virtual Part? Part { get; set; }

    public virtual Request? Request { get; set; }
}
