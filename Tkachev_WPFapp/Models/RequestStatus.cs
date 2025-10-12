using System;
using System.Collections.Generic;

namespace Tkachev_WPFapp.Models;

public partial class RequestStatus
{
    public int Id { get; set; }

    public string? Value { get; set; }

    public virtual ICollection<Request> Requests { get; set; } = new List<Request>();
}
