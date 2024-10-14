using System;
using System.Collections.Generic;

namespace RZAWebsite_J.Models;

public partial class Educationalbooking
{
    public int CustomerId { get; set; }

    public int EducationalbookingId { get; set; }

    public virtual Customer Customer { get; set; } = null!;
}
