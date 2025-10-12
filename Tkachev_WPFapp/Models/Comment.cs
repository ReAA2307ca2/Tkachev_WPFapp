using System;
using System.Collections.Generic;

namespace Tkachev_WPFapp.Models;

public partial class Comment
{
    public int Id { get; set; }

    public string? Message { get; set; }

    public int? MasterId { get; set; }

    public int? RequestId { get; set; }

    public virtual Master? Master { get; set; }

    public virtual Request? Request { get; set; }
}
