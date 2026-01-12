using System;
using System.Collections.Generic;

namespace esg_mcp_server.Data;

public partial class BacodeD
{
    public string CodeField { get; set; } = null!;

    public string ContentId { get; set; } = null!;

    public string ContentDesc { get; set; } = null!;

    public string CEnable { get; set; } = null!;

    public string CreateUser { get; set; } = null!;

    public DateTime CreateDate { get; set; }

    public string TransUser { get; set; } = null!;

    public DateTime TransDate { get; set; }

    public int LockId { get; set; }
}
