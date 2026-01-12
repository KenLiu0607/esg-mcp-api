using System;
using System.Collections.Generic;

namespace esg_mcp_server.Data;

public partial class EsgCourse
{
    public string OrgCode { get; set; } = null!;

    public string CYear { get; set; } = null!;

    public string OpName { get; set; } = null!;

    public int Seq { get; set; }

    public string CourseName { get; set; } = null!;

    public decimal CourseHours { get; set; }

    public int CourseEmps { get; set; }

    public string Memo { get; set; } = null!;

    public string CreateUser { get; set; } = null!;

    public DateTime CreateDate { get; set; }

    public string TransUser { get; set; } = null!;

    public DateTime? TransDate { get; set; }
}
