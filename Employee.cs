using System;
using System.Collections.Generic;

namespace IAM.Models;

public partial class Employee
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? EmailId { get; set; }

    public string? PhoneNo { get; set; }

    public string? Gender { get; set; }

    public bool? Status { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDt { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDt { get; set; }
}
