using System;
using System.Collections.Generic;

namespace esg_mcp_server.Data;

public partial class EsgWaterRe
{
    public string OrgCode { get; set; } = null!;

    public string CYear { get; set; } = null!;

    public string OpName { get; set; } = null!;

    public string ColLoc { get; set; } = null!;

    public string EexLoc { get; set; } = null!;

    public string ColDisYn { get; set; } = null!;

    public int RegCod { get; set; }

    public int RegBod { get; set; }

    public int RegSs { get; set; }

    public int RegAn { get; set; }

    public int RegTcc { get; set; }

    public int RegDio { get; set; }

    public int CustCod { get; set; }

    public int CustBod { get; set; }

    public int CustSs { get; set; }

    public int CustAn { get; set; }

    public int CustTcc { get; set; }

    public int CustDio { get; set; }

    public decimal ActCod { get; set; }

    public decimal ActBod { get; set; }

    public decimal ActSs { get; set; }

    public decimal ActAn { get; set; }

    public decimal ActTcc { get; set; }

    public decimal ActDio { get; set; }

    public int DegNon { get; set; }

    public int Deg1st { get; set; }

    public int Deg2nd { get; set; }

    public int Deg3rd { get; set; }

    public string CustBase { get; set; } = null!;

    public int CustStdDays { get; set; }

    public decimal ActCodTotal { get; set; }

    public string Mang01Desc { get; set; } = null!;

    public string Mang02Desc { get; set; } = null!;

    public string Mang03Desc { get; set; } = null!;

    public string Mang04Desc { get; set; } = null!;

    public string Mang05Desc { get; set; } = null!;

    public string Mang06Desc { get; set; } = null!;

    public string Mang07Desc { get; set; } = null!;

    public string Mang08Desc { get; set; } = null!;

    public string Mang09Desc { get; set; } = null!;

    public string Mang10Desc { get; set; } = null!;

    public int TakeSurface { get; set; }

    public int TakeRain { get; set; }

    public int TakeGroundR { get; set; }

    public int TakeGroundNr { get; set; }

    public int TakeTap { get; set; }

    public int TakeExt { get; set; }

    public int TakeSum { get; set; }

    public int DrRelease { get; set; }

    public int DrSewage { get; set; }

    public int DrThrid { get; set; }

    public int DrSum { get; set; }

    public int TakeDrSum { get; set; }

    public int MaxStored { get; set; }

    public int ActStored { get; set; }

    public int CwRecycled { get; set; }

    public int CwCoolTower { get; set; }

    public int CwInside { get; set; }

    public int CwSum { get; set; }

    public int RecycledTotal { get; set; }

    public int ReusedTotal { get; set; }

    public int ProcessTotal { get; set; }

    public int WaterSum { get; set; }

    public decimal R1 { get; set; }

    public decimal R2 { get; set; }

    public decimal R3 { get; set; }

    public decimal R4 { get; set; }

    public string ColLocMemo { get; set; } = null!;

    public string EexLocMemo { get; set; } = null!;

    public string ColDisYnmemo { get; set; } = null!;

    public string RegCodMemo { get; set; } = null!;

    public string RegBodMemo { get; set; } = null!;

    public string RegSsMemo { get; set; } = null!;

    public string RegAnMemo { get; set; } = null!;

    public string RegTccMemo { get; set; } = null!;

    public string RegDioMemo { get; set; } = null!;

    public string CustCodMemo { get; set; } = null!;

    public string CustBodMemo { get; set; } = null!;

    public string CustSsMemo { get; set; } = null!;

    public string CustAnMemo { get; set; } = null!;

    public string CustTccMemo { get; set; } = null!;

    public string CustDioMemo { get; set; } = null!;

    public string ActCodMemo { get; set; } = null!;

    public string ActBodMemo { get; set; } = null!;

    public string ActSsMemo { get; set; } = null!;

    public string ActAnMemo { get; set; } = null!;

    public string ActTccMemo { get; set; } = null!;

    public string ActDioMemo { get; set; } = null!;

    public string DegNonMemo { get; set; } = null!;

    public string Deg1stMemo { get; set; } = null!;

    public string Deg2ndMemo { get; set; } = null!;

    public string Deg3rdMemo { get; set; } = null!;

    public string CustBaseMemo { get; set; } = null!;

    public string CustStdDaysMemo { get; set; } = null!;

    public string ActCodTotalMemo { get; set; } = null!;

    public string Mang01DescMemo { get; set; } = null!;

    public string Mang02DescMemo { get; set; } = null!;

    public string Mang03DescMemo { get; set; } = null!;

    public string Mang04DescMemo { get; set; } = null!;

    public string Mang05DescMemo { get; set; } = null!;

    public string Mang06DescMemo { get; set; } = null!;

    public string Mang07DescMemo { get; set; } = null!;

    public string Mang08DescMemo { get; set; } = null!;

    public string Mang09DescMemo { get; set; } = null!;

    public string Mang10DescMemo { get; set; } = null!;

    public string TakeSurfaceMemo { get; set; } = null!;

    public string TakeRainMemo { get; set; } = null!;

    public string TakeGroundRmemo { get; set; } = null!;

    public string TakeGroundNrmemo { get; set; } = null!;

    public string TakeTapMemo { get; set; } = null!;

    public string TakeExtMemo { get; set; } = null!;

    public string DrReleaseMemo { get; set; } = null!;

    public string DrSewageMemo { get; set; } = null!;

    public string DrThridMemo { get; set; } = null!;

    public string MaxStoredMemo { get; set; } = null!;

    public string ActStoredMemo { get; set; } = null!;

    public string CwRecycledMemo { get; set; } = null!;

    public string CwCoolTowerMemo { get; set; } = null!;

    public string CwInsideMemo { get; set; } = null!;

    public string CwTotalMemo { get; set; } = null!;

    public string RecycledTotalMemo { get; set; } = null!;

    public string ReusedTotalMemo { get; set; } = null!;

    public string R1memo { get; set; } = null!;

    public string R2memo { get; set; } = null!;

    public string R3memo { get; set; } = null!;

    public string R4memo { get; set; } = null!;

    public string CreateUser { get; set; } = null!;

    public DateTime CreateDate { get; set; }

    public string TransUser { get; set; } = null!;

    public DateTime? TransDate { get; set; }
}
