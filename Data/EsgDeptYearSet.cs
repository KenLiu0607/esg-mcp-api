using System;
using System.Collections.Generic;

namespace esg_mcp_server.Data;

public partial class EsgDeptYearSet
{
    public string CYear { get; set; } = null!;

    public string OrgCode { get; set; } = null!;

    public int OrderSeq { get; set; }

    public string EsgWpress { get; set; } = null!;

    public string EsgGhGasType { get; set; } = null!;

    public string ModYn { get; set; } = null!;

    public string CreateUser { get; set; } = null!;

    public DateTime CreateDate { get; set; }

    public string TransUser { get; set; } = null!;

    public DateTime TransDate { get; set; }
}
