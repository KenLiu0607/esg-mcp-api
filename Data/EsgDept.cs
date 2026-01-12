using System;
using System.Collections.Generic;

namespace esg_mcp_server.Data;

public partial class EsgDept
{
    public string OrgCode { get; set; } = null!;

    public string EsgBg { get; set; } = null!;

    public string EsgBgarea { get; set; } = null!;

    public string EsgBgareaType { get; set; } = null!;

    public string MfBaseYn { get; set; } = null!;

    public string CreateUser { get; set; } = null!;

    public DateTime CreateDate { get; set; }

    public string TransUser { get; set; } = null!;

    public DateTime TransDate { get; set; }
}
