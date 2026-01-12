using System;
using System.Collections.Generic;

namespace esg_mcp_server.Data;

public partial class EsgLicense
{
    public string OrgCode { get; set; } = null!;

    public string CYear { get; set; } = null!;

    public string Iso9001 { get; set; } = null!;

    public string Iso14001 { get; set; } = null!;

    public string Iso45001 { get; set; } = null!;

    public string Iso50001 { get; set; } = null!;

    public string Fsc { get; set; } = null!;

    public string Pefc { get; set; } = null!;

    public string Iso14064 { get; set; } = null!;

    public string Iso14067 { get; set; } = null!;

    public string Other { get; set; } = null!;

    public string Iso9001unit { get; set; } = null!;

    public string Iso14001unit { get; set; } = null!;

    public string Iso45001unit { get; set; } = null!;

    public string Iso50001unit { get; set; } = null!;

    public string Fscunit { get; set; } = null!;

    public string Pefcunit { get; set; } = null!;

    public string CreateUser { get; set; } = null!;

    public DateTime CreateDate { get; set; }

    public string TransUser { get; set; } = null!;

    public DateTime? TransDate { get; set; }
}
