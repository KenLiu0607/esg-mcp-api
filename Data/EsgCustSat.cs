using System;
using System.Collections.Generic;

namespace esg_mcp_server.Data;

public partial class EsgCustSat
{
    public string OrgCode { get; set; } = null!;

    public string CYear { get; set; } = null!;

    public string OpName { get; set; } = null!;

    public string SurveyObj { get; set; } = null!;

    public string Freq { get; set; } = null!;

    public string Method { get; set; } = null!;

    public string Scoring { get; set; } = null!;

    public int SatiQty { get; set; }

    public int TotalQty { get; set; }

    public decimal SatiRatio { get; set; }

    public string SurveyObjMemo { get; set; } = null!;

    public string FreqMemo { get; set; } = null!;

    public string MethodMemo { get; set; } = null!;

    public string ScoringMemo { get; set; } = null!;

    public string SatiQtyMemo { get; set; } = null!;

    public string TotalQtyMemo { get; set; } = null!;

    public string SatiRatioMemo { get; set; } = null!;

    public string CreateUser { get; set; } = null!;

    public DateTime CreateDate { get; set; }

    public string TransUser { get; set; } = null!;

    public DateTime? TransDate { get; set; }
}
