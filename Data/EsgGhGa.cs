using System;
using System.Collections.Generic;

namespace esg_mcp_server.Data;

public partial class EsgGhGa
{
    public string OrgCode { get; set; } = null!;

    public string CYear { get; set; } = null!;

    public decimal Gas1 { get; set; }

    public decimal Gas2 { get; set; }

    public decimal GasSum { get; set; }

    public decimal Bm { get; set; }

    public decimal Co2 { get; set; }

    public decimal Ch4 { get; set; }

    public decimal N2o { get; set; }

    public decimal Hfcs { get; set; }

    public decimal Pfcs { get; set; }

    public decimal Sf6 { get; set; }

    public decimal Nf3 { get; set; }

    public string Memo { get; set; } = null!;

    public string MemoFu { get; set; } = null!;

    public decimal ChpPulp { get; set; }

    public decimal ChpCt { get; set; }

    public string PulpCtMemo { get; set; } = null!;

    public string CreateUser { get; set; } = null!;

    public DateTime CreateDate { get; set; }

    public string TransUser { get; set; } = null!;

    public DateTime? TransDate { get; set; }
}
