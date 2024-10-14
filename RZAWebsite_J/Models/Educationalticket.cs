using System;
using System.Collections.Generic;

namespace RZAWebsite_J.Models;

public partial class Educationalticket
{
    public int EducationalbookingId { get; set; }

    public int AttractionId { get; set; }

    public DateOnly? Bookingdate { get; set; }

    public int? Capacity { get; set; }

    public float? Prices { get; set; }

    public virtual Attraction Attraction { get; set; } = null!;
}
