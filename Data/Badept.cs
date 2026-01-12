using System;
using System.Collections.Generic;

namespace esg_mcp_server.Data;

public partial class Badept
{
    public string OrgCode { get; set; } = null!;

    public string CompanyId { get; set; } = null!;

    public string EiscompId { get; set; } = null!;

    public string EisdeptId { get; set; } = null!;

    public string Eisopid { get; set; } = null!;

    public string DeptDesc { get; set; } = null!;

    public string CountryId { get; set; } = null!;

    public string CurrencyId { get; set; } = null!;

    public string DeptArea { get; set; } = null!;

    public string IsBranch { get; set; } = null!;

    public string Remark { get; set; } = null!;

    public string CEnable { get; set; } = null!;

    public string CreateUser { get; set; } = null!;

    public DateTime CreateDate { get; set; }

    public string TransUser { get; set; } = null!;

    public DateTime TransDate { get; set; }

    public int LockId { get; set; }
}
