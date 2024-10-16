﻿using System;
using System.Collections.Generic;

namespace RZAWebsite_J.Models;

public partial class Room
{
    public int RoomNumber { get; set; }

    public int TypeId { get; set; }

    public int? Capacity { get; set; }

    public string? RoomType { get; set; }

    public virtual Type Type { get; set; } = null!;
}
