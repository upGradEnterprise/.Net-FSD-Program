using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class Emp
{
    public int Empno { get; set; }

    public string? Ename { get; set; }

    public string? Job { get; set; }

    public int? Salary { get; set; }

    public int? Deptno { get; set; }

    public virtual Dept? Dept { get; set; }
}
