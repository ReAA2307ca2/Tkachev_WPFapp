using System;
using System.Collections.Generic;

namespace Tkachev_WPFapp.Models;

public partial class Request
{
    public int Id { get; set; }

    public DateOnly? StartDate { get; set; }

    public int? TechModel { get; set; }

    public string? Description { get; set; }

    public int? Status { get; set; }

    public DateOnly? CompletionDate { get; set; }

    public int? ClientId { get; set; }

    public virtual Client? Client { get; set; }

    public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();

    public virtual ICollection<RequestsPart> RequestsParts { get; set; } = new List<RequestsPart>();

    public virtual RequestStatus? StatusNavigation { get; set; }

    public virtual TechModel? TechModelNavigation { get; set; }
}
