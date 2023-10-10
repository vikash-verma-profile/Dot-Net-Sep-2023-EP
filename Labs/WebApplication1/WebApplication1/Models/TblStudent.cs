using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class TblStudent
{
    public int Id { get; set; }

    public string? StudentName { get; set; }

    public int? CourseId { get; set; }
}
