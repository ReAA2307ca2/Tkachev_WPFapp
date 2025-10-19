using System;
using System.Collections.Generic;

namespace Tkachev_WPFapp.Models;

public partial class Client
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Phone { get; set; }

    public string? Login { get; set; }

    public string? Password { get; set; }

    public virtual ICollection<Request> Requests { get; set; } = new List<Request>();

    public override string ToString()
    {
        return this.Name;
    }
}
