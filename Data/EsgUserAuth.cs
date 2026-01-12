using System;
using System.Collections.Generic;

namespace esg_mcp_server.Data;

public partial class EsgUserAuth
{
    public string UserId { get; set; } = null!;

    public string OrgCode { get; set; } = null!;

    public string CMemo { get; set; } = null!;

    public string CreateUser { get; set; } = null!;

    public DateTime CreateDate { get; set; }
}
