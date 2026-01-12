using System;
using System.Collections.Generic;

namespace esg_mcp_server.Data;

public partial class BauserGroup
{
    public string UserGroupId { get; set; } = null!;

    public string UserGroupName { get; set; } = null!;

    public string SysArea { get; set; } = null!;

    public string CEnable { get; set; } = null!;

    public string CreateUser { get; set; } = null!;

    public DateTime CreateDate { get; set; }

    public string TransUser { get; set; } = null!;

    public DateTime TransDate { get; set; }

    public int LockId { get; set; }
}
