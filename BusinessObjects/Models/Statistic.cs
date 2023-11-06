using System;
using System.Collections.Generic;

namespace BusinessObjects.Models;

public partial class Statistic
{
    public int StatisticId { get; set; }

    public Guid? StaffId { get; set; }

    public DateTime? StatisticDate { get; set; }

    public int? TotalExamProfile { get; set; }

    public int? TotalQuizDid { get; set; }

    public int? TotalReportRate { get; set; }

    public virtual Staff Staff { get; set; }
}
