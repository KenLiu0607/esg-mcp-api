using System;
using System.Collections.Generic;

namespace esg_mcp_server.Data;

public partial class EsgProcurment
{
    public string OrgCode { get; set; } = null!;

    public string CYear { get; set; } = null!;

    public string OpName { get; set; } = null!;

    public int WoodTqy { get; set; }

    public int WoodFscFm { get; set; }

    public int WoodFscCoc100 { get; set; }

    public int WoodFscCocMix { get; set; }

    public int WoodFscCocRc { get; set; }

    public int WoodFscCocCw { get; set; }

    public int WoodPefc { get; set; }

    public int WoodOt { get; set; }

    public int WoodNone { get; set; }

    public int PulpTqy { get; set; }

    public int PulpFscFm { get; set; }

    public int PulpFscCoc100 { get; set; }

    public int PulpFscCocMix { get; set; }

    public int PulpFscCocRc { get; set; }

    public int PulpFscCocCw { get; set; }

    public int PulpPefc { get; set; }

    public int PulpOt { get; set; }

    public int PulpNone { get; set; }

    public int CtTqy { get; set; }

    public int CtFscFm { get; set; }

    public int CtFscCoc100 { get; set; }

    public int CtFscCocMix { get; set; }

    public int CtFscCocRc { get; set; }

    public int CtFscCocCw { get; set; }

    public int CtPefc { get; set; }

    public int CtOt { get; set; }

    public int CtNone { get; set; }

    public int WfTqy { get; set; }

    public int WfFscFm { get; set; }

    public int WfFscCoc100 { get; set; }

    public int WfFscCocMix { get; set; }

    public int WfFscCocRc { get; set; }

    public int WfFscCocCw { get; set; }

    public int WfPefc { get; set; }

    public int WfOt { get; set; }

    public int WfNone { get; set; }

    public int WpTqy { get; set; }

    public int WpHum { get; set; }

    public int WpOt { get; set; }

    public int SfTqy { get; set; }

    public int SfRspo { get; set; }

    public int SfOt { get; set; }

    public int SfNone { get; set; }

    public string WoodTqyMemo { get; set; } = null!;

    public string WoodFscFmmemo { get; set; } = null!;

    public string WoodFscCoc100Memo { get; set; } = null!;

    public string WoodFscCocMixMemo { get; set; } = null!;

    public string WoodFscCocRcMemo { get; set; } = null!;

    public string WoodFscCocCwMemo { get; set; } = null!;

    public string WoodPefcmemo { get; set; } = null!;

    public string WoodOtMemo { get; set; } = null!;

    public string WoodNoneMemo { get; set; } = null!;

    public string PulpTqyMemo { get; set; } = null!;

    public string PulpFscFmmemo { get; set; } = null!;

    public string PulpFscCoc100Memo { get; set; } = null!;

    public string PulpFscCocMixMemo { get; set; } = null!;

    public string PulpFscCocRcMemo { get; set; } = null!;

    public string PulpFscCocCwMemo { get; set; } = null!;

    public string PulpPefcmemo { get; set; } = null!;

    public string PulpOtMemo { get; set; } = null!;

    public string PulpNoneMemo { get; set; } = null!;

    public string CtTqyMemo { get; set; } = null!;

    public string CtFscFmmemo { get; set; } = null!;

    public string CtFscCoc100Memo { get; set; } = null!;

    public string CtFscCocMixMemo { get; set; } = null!;

    public string CtFscCocRcMemo { get; set; } = null!;

    public string CtFscCocCwMemo { get; set; } = null!;

    public string CtPefcmemo { get; set; } = null!;

    public string CtOtMemo { get; set; } = null!;

    public string CtNoneMemo { get; set; } = null!;

    public string WpTqyMemo { get; set; } = null!;

    public string WpHumMemo { get; set; } = null!;

    public string WpOtMemo { get; set; } = null!;

    public string SfTqyMemo { get; set; } = null!;

    public string SfRspoMemo { get; set; } = null!;

    public string SfOtMemo { get; set; } = null!;

    public string SfNoneMemo { get; set; } = null!;

    public string CreateUser { get; set; } = null!;

    public DateTime CreateDate { get; set; }

    public string TransUser { get; set; } = null!;

    public DateTime? TransDate { get; set; }
}
