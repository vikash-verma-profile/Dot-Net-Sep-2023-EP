using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class TblCourseBookMapping
{
    public int Id { get; set; }

    public int? CourseId { get; set; }

    public int? BookId { get; set; }
}
