using System;
using System.Collections.Generic;

namespace esg_mcp_server.Data;

public partial class BauserMenuAuth
{
    public string SecKind { get; set; } = null!;

    public string UserId { get; set; } = null!;

    public string UserGroupId { get; set; } = null!;

    public int MenuId { get; set; }

    public string CModify { get; set; } = null!;

    public string CreateUser { get; set; } = null!;

    public DateTime CreateDate { get; set; }

    public string TransUser { get; set; } = null!;

    public DateTime TransDate { get; set; }
}
