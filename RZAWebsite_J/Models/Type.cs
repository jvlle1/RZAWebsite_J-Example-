using System;
using System.Collections.Generic;

namespace RZAWebsite_J.Models;

public partial class Type
{
    public int TypeId { get; set; }

    public virtual ICollection<Room> Rooms { get; set; } = new List<Room>();
}
