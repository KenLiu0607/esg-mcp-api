using System;
using System.Collections.Generic;

namespace esg_mcp_server.Data;

public partial class BacodeM
{
    public string CodeField { get; set; } = null!;

    public string CodeName { get; set; } = null!;

    public string SysMain { get; set; } = null!;

    public byte CodeLen { get; set; }

    public string CodeFixFlag { get; set; } = null!;

    public string Remarks { get; set; } = null!;

    public string CEnable { get; set; } = null!;

    public string CreateUser { get; set; } = null!;

    public DateTime CreateDate { get; set; }

    public string TransUser { get; set; } = null!;

    public DateTime TransDate { get; set; }

    public int LockId { get; set; }
}
