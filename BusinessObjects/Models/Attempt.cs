﻿using System;
using System.Collections.Generic;

namespace BusinessObjects.Models;

public partial class Attempt
{
    public Guid AttemptId { get; set; }

    public Guid? UserId { get; set; }

    public int QuizId { get; set; }

    public DateTime? AttemptDate { get; set; }

    public decimal? Grade { get; set; }

    public virtual ICollection<AttemptDetail> AttemptDetails { get; set; } = new List<AttemptDetail>();

    public virtual Quiz Quiz { get; set; }

    public virtual User User { get; set; }
}
