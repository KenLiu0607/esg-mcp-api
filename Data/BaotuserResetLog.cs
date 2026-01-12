using System;
using System.Collections.Generic;

namespace esg_mcp_server.Data;

public partial class BaotuserResetLog
{
    public int Seq { get; set; }

    public string OtuserId { get; set; } = null!;

    public string CreateUser { get; set; } = null!;

    public DateTime CreateDate { get; set; }
}
