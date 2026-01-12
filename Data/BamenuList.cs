using System;
using System.Collections.Generic;

namespace esg_mcp_server.Data;

public partial class BamenuList
{
    public int MenuId { get; set; }

    public string MenuType { get; set; } = null!;

    public string SysArea { get; set; } = null!;

    public string CControl { get; set; } = null!;

    public string MenuNo { get; set; } = null!;

    public string MenuDesc { get; set; } = null!;

    public int ParentMenuId { get; set; }

    public int CSort { get; set; }

    public string CEnable { get; set; } = null!;

    public string CreateUser { get; set; } = null!;

    public DateTime CreateDate { get; set; }

    public string TransUser { get; set; } = null!;

    public DateTime TransDate { get; set; }

    public int LockId { get; set; }
}
