using System;
using System.Collections.Generic;

namespace Tkachev_WPFapp.Models;

public partial class Request
{
    public int Id { get; set; }

    public DateOnly? StartDate { get; set; }

    public int? TechModelId { get; set; }

    public string? Description { get; set; }

    public int? StatusId { get; set; }

    public DateOnly? CompletionDate { get; set; }

    public int? ClientId { get; set; }

    public virtual Client? Client { get; set; }

    public virtual ICollection<RequestPart> RequestParts { get; set; } = new List<RequestPart>();

    public virtual RequestStatus? Status { get; set; }

    public virtual TechModel? TechModel { get; set; }
}
