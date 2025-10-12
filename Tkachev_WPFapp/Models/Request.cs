using System;
using System.Collections.Generic;

namespace Tkachev_WPFapp.Models;

public partial class Request
{
    public int Id { get; set; }

    public DateOnly? StartDate { get; set; }

    public int? TechModel { get; set; }

    public string? ProblemDescription { get; set; }

    public int? Status { get; set; }

    public DateOnly? CompletionDate { get; set; }

    public int? ClientId { get; set; }

    public virtual Client? Client { get; set; }

    public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();

    public virtual ICollection<RequestPart> RequestParts { get; set; } = new List<RequestPart>();

    public virtual RequestStatus? StatusNavigation { get; set; }

    public virtual TechModel? TechModelNavigation { get; set; }
}
