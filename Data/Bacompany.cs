using System;
using System.Collections.Generic;

namespace esg_mcp_server.Data;

public partial class Bacompany
{
    public string CompanyId { get; set; } = null!;

    public string EiscompId { get; set; } = null!;

    public string ImkeyId { get; set; } = null!;

    public string AccCom { get; set; } = null!;

    public string CompDesc { get; set; } = null!;

    public string CountryId { get; set; } = null!;

    public string CurrencyId { get; set; } = null!;

    public string TaxId { get; set; } = null!;

    public string PhoneNo { get; set; } = null!;

    public string FaxNo { get; set; } = null!;

    public string CompanyAddr { get; set; } = null!;

    public string CompType { get; set; } = null!;

    public string Bgid { get; set; } = null!;

    public string CompArea { get; set; } = null!;

    public string Remark { get; set; } = null!;

    public string CEnable { get; set; } = null!;

    public string CreateUser { get; set; } = null!;

    public DateTime CreateDate { get; set; }

    public string TransUser { get; set; } = null!;

    public DateTime TransDate { get; set; }

    public int LockId { get; set; }
}
