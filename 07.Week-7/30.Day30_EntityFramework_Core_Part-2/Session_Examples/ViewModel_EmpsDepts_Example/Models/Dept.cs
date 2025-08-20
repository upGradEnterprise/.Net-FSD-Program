using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class Dept
{
    public int Deptno { get; set; }

    public string Dname { get; set; } = null!;

    public string? Loc { get; set; }

    public virtual ICollection<Emp> Emps { get; set; } = new List<Emp>();
}
