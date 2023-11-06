﻿using System;
using System.Collections.Generic;

namespace BusinessObjects.Models;

public partial class Account
{
    public Guid AccountId { get; set; }

    public string Username { get; set; }

    public string Password { get; set; }

    public string Role { get; set; }

    public virtual Admin Admin { get; set; }

    public virtual Staff Staff { get; set; }

    public virtual Teacher Teacher { get; set; }

    public virtual User User { get; set; }
}
