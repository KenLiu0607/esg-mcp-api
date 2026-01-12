using System;
using System.Collections.Generic;

namespace esg_mcp_server.Data;

public partial class BamenuName
{
    public int MenuId { get; set; }

    public string LanguageId { get; set; } = null!;

    public string MenuName { get; set; } = null!;

    public string CreateUser { get; set; } = null!;

    public DateTime CreateDate { get; set; }

    public string TransUser { get; set; } = null!;

    public DateTime TransDate { get; set; }

    public int LockId { get; set; }
}
