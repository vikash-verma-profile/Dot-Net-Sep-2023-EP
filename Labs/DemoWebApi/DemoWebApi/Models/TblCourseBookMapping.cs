using System;
using System.Collections.Generic;

namespace DemoWebApi.Models;

public partial class TblCourseBookMapping
{
    public int Id { get; set; }

    public int? CourseId { get; set; }

    public int? BookId { get; set; }
}
