using System;
using System.Collections.Generic;

namespace esg_mcp_server.Data;

public partial class EsgNonGhGa
{
    public string OrgCode { get; set; } = null!;

    public string CYear { get; set; } = null!;

    public string OpName { get; set; } = null!;

    public decimal Cfcs { get; set; }

    public decimal Hcfcs { get; set; }

    public decimal Hln { get; set; }

    public decimal Mbx { get; set; }

    public decimal Nox { get; set; }

    public decimal Sox { get; set; }

    public decimal Pm { get; set; }

    public decimal Vocs { get; set; }

    public decimal Dioxin { get; set; }

    public decimal Leads { get; set; }

    public decimal Cadmium { get; set; }

    public decimal Mercury { get; set; }

    public decimal Arsenic { get; set; }

    public decimal Hex { get; set; }

    public string CfcsMemo { get; set; } = null!;

    public string HcfcsMemo { get; set; } = null!;

    public string Hlnmemo { get; set; } = null!;

    public string MbxMemo { get; set; } = null!;

    public string NoxMemo { get; set; } = null!;

    public string SoxMemo { get; set; } = null!;

    public string Pmmemo { get; set; } = null!;

    public string VocsMemo { get; set; } = null!;

    public string DioxinMemo { get; set; } = null!;

    public string LeadMemo { get; set; } = null!;

    public string CadmiumMemo { get; set; } = null!;

    public string MercuryMemo { get; set; } = null!;

    public string ArsenicMemo { get; set; } = null!;

    public string HexMemo { get; set; } = null!;

    public string CreateUser { get; set; } = null!;

    public DateTime CreateDate { get; set; }

    public string TransUser { get; set; } = null!;

    public DateTime? TransDate { get; set; }
}
