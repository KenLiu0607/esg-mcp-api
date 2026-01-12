using System;
using System.Collections.Generic;

namespace esg_mcp_server.Data;

public partial class EsgProdInfo
{
    public string OrgCode { get; set; } = null!;

    public string CYear { get; set; } = null!;

    public string OpName { get; set; } = null!;

    public int GreenMt { get; set; }

    public int PulpMt { get; set; }

    public int PulpAdt { get; set; }

    public int PaperMt { get; set; }

    public int PaperAdt { get; set; }

    public int ChpHouseMt { get; set; }

    public int ChpHouseAdt { get; set; }

    public int PulpMt2 { get; set; }

    public int PulpAdt2 { get; set; }

    public int PaperMt2 { get; set; }

    public int PaperAdt2 { get; set; }

    public int ChpHouseMt2 { get; set; }

    public int ChpHouseAdt2 { get; set; }

    public int CartonMt { get; set; }

    public int CartonAdt { get; set; }

    public int ProMt { get; set; }

    public int ProAdt { get; set; }

    public int ProSk { get; set; }

    public int HouseMt { get; set; }

    public int HouseAdt { get; set; }

    public int CleanMt { get; set; }

    public string GreenMemo { get; set; } = null!;

    public string PulpMtmemo { get; set; } = null!;

    public string PulpAdtmemo { get; set; } = null!;

    public string PaperMtmemo { get; set; } = null!;

    public string PaperAdtmemo { get; set; } = null!;

    public string ChpHouseMtmemo { get; set; } = null!;

    public string ChpHouseAdtmemo { get; set; } = null!;

    public string CartonMtmemo { get; set; } = null!;

    public string CartonAdtmemo { get; set; } = null!;

    public string ProMtmemo { get; set; } = null!;

    public string ProAdtmemo { get; set; } = null!;

    public string ProSkmemo { get; set; } = null!;

    public string HouseMtmemo { get; set; } = null!;

    public string HouseAdtmemo { get; set; } = null!;

    public string CleanMtmemo { get; set; } = null!;

    public string CreateUser { get; set; } = null!;

    public DateTime CreateDate { get; set; }

    public string TransUser { get; set; } = null!;

    public DateTime? TransDate { get; set; }
}
