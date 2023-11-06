using System;
using System.Collections.Generic;

namespace BusinessObjects.Models;

public partial class Admin
{
    public Guid AdminId { get; set; }

    public Guid? AccountId { get; set; }

    public string FullName { get; set; }

    public string Email { get; set; }

    public string ContactNumber { get; set; }

    public virtual Account Account { get; set; }
}
