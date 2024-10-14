using System;
using System.Collections.Generic;

namespace RZAWebsite_J.Models;

public partial class Zoobooking
{
    public int CustomerId { get; set; }

    public int ZoobookingId { get; set; }

    public virtual Customer Customer { get; set; } = null!;
}
