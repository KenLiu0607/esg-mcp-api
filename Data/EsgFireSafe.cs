using System;
using System.Collections.Generic;

namespace esg_mcp_server.Data;

public partial class EsgFireSafe
{
    public string OrgCode { get; set; } = null!;

    public string CYear { get; set; } = null!;

    public string OpName { get; set; } = null!;

    public int FireQty { get; set; }

    public int DeathQty { get; set; }

    public int IjuredQty { get; set; }

    public string DamageCurr { get; set; } = null!;

    public int DamageAmt { get; set; }

    public string Improve { get; set; } = null!;

    public string FireQtyMemo { get; set; } = null!;

    public string DeathQtyMemo { get; set; } = null!;

    public string IjuredQtyMemo { get; set; } = null!;

    public string DamageAmtMemo { get; set; } = null!;

    public string ImproveMemo { get; set; } = null!;

    public string CreateUser { get; set; } = null!;

    public DateTime CreateDate { get; set; }

    public string TransUser { get; set; } = null!;

    public DateTime? TransDate { get; set; }
}
