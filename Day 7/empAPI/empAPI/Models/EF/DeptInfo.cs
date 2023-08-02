using System;
using System.Collections.Generic;

namespace empAPI.Models.EF;

public partial class DeptInfo
{
    public int DeptNo { get; set; }

    public string? DeptName { get; set; }

    public string? DeptCity { get; set; }
}
