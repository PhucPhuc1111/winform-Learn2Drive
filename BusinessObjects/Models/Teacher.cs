﻿using System;
using System.Collections.Generic;

namespace BusinessObjects.Models;

public partial class Teacher
{
    public Guid TeacherId { get; set; }

    public Guid? AccountId { get; set; }

    public string FullName { get; set; }

    public string Information { get; set; }

    public string ContactNumber { get; set; }

    public string Email { get; set; }

    public string Avatar { get; set; }

    public virtual Account Account { get; set; }

    public virtual ICollection<Hire> Hires { get; set; } = new List<Hire>();
}
