using System;
using System.Collections.Generic;

namespace esg_mcp_server.Data;

public partial class EsgRawMaterial
{
    public string CYear { get; set; } = null!;

    public string OrgCode { get; set; } = null!;

    public string OpName { get; set; } = null!;

    public int Mwood { get; set; }

    public int Mpulp { get; set; }

    public int Mct { get; set; }

    public int Mwp { get; set; }

    public int MwpW { get; set; }

    public int MwpC { get; set; }

    public int Mstarch { get; set; }

    public int OtM { get; set; }

    public string OtMdesc { get; set; } = null!;

    public int SubLime { get; set; }

    public int SubMs { get; set; }

    public int SubIsalt { get; set; }

    public int SubOt { get; set; }

    public string SubOtDesc { get; set; } = null!;

    public int PackPaper { get; set; }

    public int PackPlastic { get; set; }

    public int PackMetal { get; set; }

    public int Greg { get; set; }

    public string GregDesc { get; set; } = null!;

    public int GnonReg { get; set; }

    public string GnonRegDesc { get; set; } = null!;

    public string MwoodMemo { get; set; } = null!;

    public string MpulpMemo { get; set; } = null!;

    public string MctMemo { get; set; } = null!;

    public string MwpMemo { get; set; } = null!;

    public string MwpWmemo { get; set; } = null!;

    public string MwpCmemo { get; set; } = null!;

    public string MstarchMemo { get; set; } = null!;

    public string OtMmemo { get; set; } = null!;

    public string OtMdescMemo { get; set; } = null!;

    public string SubLimeMemo { get; set; } = null!;

    public string SubMsMemo { get; set; } = null!;

    public string SubIsaltMemo { get; set; } = null!;

    public string SubOtMemo { get; set; } = null!;

    public string SubOtDescMemo { get; set; } = null!;

    public string PackPaperMemo { get; set; } = null!;

    public string PackPlasticMemo { get; set; } = null!;

    public string PackMetalMemo { get; set; } = null!;

    public string GregMemo { get; set; } = null!;

    public string GregDescMemo { get; set; } = null!;

    public string GnonRegMemo { get; set; } = null!;

    public string GnonRegDescMemo { get; set; } = null!;

    public string CreateUser { get; set; } = null!;

    public DateTime CreateDate { get; set; }

    public string TransUser { get; set; } = null!;

    public DateTime? TransDate { get; set; }
}
