using System;
using System.Collections.Generic;

namespace esg_mcp_server.Data;

public partial class BacompanyName
{
    public string CompanyId { get; set; } = null!;

    public string LanguageId { get; set; } = null!;

    public string CompNameS { get; set; } = null!;

    public string CompName { get; set; } = null!;

    public string CompAddr { get; set; } = null!;

    public string CreateUser { get; set; } = null!;

    public DateTime CreateDate { get; set; }

    public string TransUser { get; set; } = null!;

    public DateTime TransDate { get; set; }

    public int LockId { get; set; }
}
