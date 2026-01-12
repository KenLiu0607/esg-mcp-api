using System;
using System.Collections.Generic;

namespace esg_mcp_server.Data;

public partial class EsgOshyfy
{
    public string OrgCode { get; set; } = null!;

    public string CYear { get; set; } = null!;

    public int EmpWorkHr { get; set; }

    public int NempWorkHr { get; set; }

    public int EmpDisNum { get; set; }

    public int NempDisNum { get; set; }

    public int EmpAccNum { get; set; }

    public int NempAccNum { get; set; }

    public string EmpInjType { get; set; } = null!;

    public string NempInjType { get; set; } = null!;

    public string CreateUser { get; set; } = null!;

    public DateTime CreateDate { get; set; }

    public string TransUser { get; set; } = null!;

    public DateTime? TransDate { get; set; }
}
