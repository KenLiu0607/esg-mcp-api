using System;
using System.Collections.Generic;

namespace esg_mcp_server.Data;

public partial class BarptField
{
    public string ReportId { get; set; } = null!;

    public string FieldId { get; set; } = null!;

    public string FieldDesc { get; set; } = null!;

    public string CreateUser { get; set; } = null!;

    public DateTime CreateDate { get; set; }

    public string TransUser { get; set; } = null!;

    public DateTime TransDate { get; set; }
}
