using System;
using System.Collections.Generic;

namespace esg_mcp_server.Data;

public partial class EsgFin
{
    public string OrgCode { get; set; } = null!;

    public string CYear { get; set; } = null!;

    public decimal OpIncome { get; set; }

    public string OpIncomeMemo { get; set; } = null!;

    public string CreateUser { get; set; } = null!;

    public DateTime CreateDate { get; set; }

    public string TransUser { get; set; } = null!;

    public DateTime? TransDate { get; set; }
}
