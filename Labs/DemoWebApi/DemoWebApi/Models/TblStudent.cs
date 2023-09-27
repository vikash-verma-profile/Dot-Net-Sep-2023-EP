using System;
using System.Collections.Generic;

namespace DemoWebApi.Models;

public partial class TblStudent
{
    public int Id { get; set; }

    public string? StudentName { get; set; }

    public int? CourseId { get; set; }
}
