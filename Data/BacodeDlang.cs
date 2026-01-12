using System;
using System.Collections.Generic;

namespace esg_mcp_server.Data;

public partial class BacodeDlang
{
    public string CodeField { get; set; } = null!;

    public string ContentId { get; set; } = null!;

    public string LanguageId { get; set; } = null!;

    public string ContentName { get; set; } = null!;

    public int CSort { get; set; }

    public string CreateUser { get; set; } = null!;

    public DateTime CreateDate { get; set; }

    public string TransUser { get; set; } = null!;

    public DateTime TransDate { get; set; }
}
