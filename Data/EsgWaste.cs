using System;
using System.Collections.Generic;

namespace esg_mcp_server.Data;

public partial class EsgWaste
{
    public string OrgCode { get; set; } = null!;

    public string CYear { get; set; } = null!;

    public string OpName { get; set; } = null!;

    public int AselfReuse { get; set; }

    public int AselfRec { get; set; }

    public int AselfAlt { get; set; }

    public int AselfBurn { get; set; }

    public int AselfBury { get; set; }

    public int AselfOt { get; set; }

    public int AselfSum { get; set; }

    public int AfdReuse { get; set; }

    public int AfdRec { get; set; }

    public int AfdAlt { get; set; }

    public int AfdBurn { get; set; }

    public int AfdBury { get; set; }

    public int AfdOt { get; set; }

    public int AfdSum { get; set; }

    public int AosReuse { get; set; }

    public int AosRec { get; set; }

    public int AosAlt { get; set; }

    public int AosBurn { get; set; }

    public int AosBury { get; set; }

    public int AosOt { get; set; }

    public int AosSum { get; set; }

    public int AreuseSum { get; set; }

    public int ArecSum { get; set; }

    public int AaltSum { get; set; }

    public int AburnSum { get; set; }

    public int AburySum { get; set; }

    public int AotSum { get; set; }

    public int AtransSum { get; set; }

    public int AdisposeSum { get; set; }

    public int Asum { get; set; }

    public string Adesc { get; set; } = null!;

    public int BselfReuse { get; set; }

    public int BselfRec { get; set; }

    public int BselfAlt { get; set; }

    public int BselfBurn { get; set; }

    public int BselfBury { get; set; }

    public int BselfOt { get; set; }

    public int BselfSum { get; set; }

    public int BfdReuse { get; set; }

    public int BfdRec { get; set; }

    public int BfdAlt { get; set; }

    public int BfdBurn { get; set; }

    public int BfdBury { get; set; }

    public int BfdOt { get; set; }

    public int BfdSum { get; set; }

    public int BosReuse { get; set; }

    public int BosRec { get; set; }

    public int BosAlt { get; set; }

    public int BosBurn { get; set; }

    public int BosBury { get; set; }

    public int BosOt { get; set; }

    public int BosSum { get; set; }

    public int BreuseSum { get; set; }

    public int BrecSum { get; set; }

    public int BaltSum { get; set; }

    public int BburnSum { get; set; }

    public int BburySum { get; set; }

    public int BotSum { get; set; }

    public int BtransSum { get; set; }

    public int BdisposeSum { get; set; }

    public int Bsum { get; set; }

    public string Bdesc { get; set; } = null!;

    public int CselfReuse { get; set; }

    public int CselfRec { get; set; }

    public int CselfAlt { get; set; }

    public int CselfBurn { get; set; }

    public int CselfBury { get; set; }

    public int CselfOt { get; set; }

    public int CselfSum { get; set; }

    public int CfdReuse { get; set; }

    public int CfdRec { get; set; }

    public int CfdAlt { get; set; }

    public int CfdBurn { get; set; }

    public int CfdBury { get; set; }

    public int CfdOt { get; set; }

    public int CfdSum { get; set; }

    public int CosReuse { get; set; }

    public int CosRec { get; set; }

    public int CosAlt { get; set; }

    public int CosBurn { get; set; }

    public int CosBury { get; set; }

    public int CosOt { get; set; }

    public int CosSum { get; set; }

    public int CreuseSum { get; set; }

    public int CrecSum { get; set; }

    public int CaltSum { get; set; }

    public int CburnSum { get; set; }

    public int CburySum { get; set; }

    public int CotSum { get; set; }

    public int CtransSum { get; set; }

    public int CdisposeSum { get; set; }

    public int Csum { get; set; }

    public string Cdesc { get; set; } = null!;

    public int DselfReuse { get; set; }

    public int DselfRec { get; set; }

    public int DselfAlt { get; set; }

    public int DselfBurn { get; set; }

    public int DselfBury { get; set; }

    public int DselfOt { get; set; }

    public int DselfSum { get; set; }

    public int DfdReuse { get; set; }

    public int DfdRec { get; set; }

    public int DfdAlt { get; set; }

    public int DfdBurn { get; set; }

    public int DfdBury { get; set; }

    public int DfdOt { get; set; }

    public int DfdSum { get; set; }

    public int DosReuse { get; set; }

    public int DosRec { get; set; }

    public int DosAlt { get; set; }

    public int DosBurn { get; set; }

    public int DosBury { get; set; }

    public int DosOt { get; set; }

    public int DosSum { get; set; }

    public int DreuseSum { get; set; }

    public int DrecSum { get; set; }

    public int DaltSum { get; set; }

    public int DburnSum { get; set; }

    public int DburySum { get; set; }

    public int DotSum { get; set; }

    public int DtransSum { get; set; }

    public int DdisposeSum { get; set; }

    public int Dsum { get; set; }

    public string Ddesc { get; set; } = null!;

    public decimal EselfReuse { get; set; }

    public decimal EselfRec { get; set; }

    public decimal EselfAlt { get; set; }

    public decimal EselfBurn { get; set; }

    public decimal EselfBury { get; set; }

    public decimal EselfOt { get; set; }

    public decimal EselfSum { get; set; }

    public decimal EfdReuse { get; set; }

    public decimal EfdRec { get; set; }

    public decimal EfdAlt { get; set; }

    public decimal EfdBurn { get; set; }

    public decimal EfdBury { get; set; }

    public decimal EfdOt { get; set; }

    public decimal EfdSum { get; set; }

    public decimal EosReuse { get; set; }

    public decimal EosRec { get; set; }

    public decimal EosAlt { get; set; }

    public decimal EosBurn { get; set; }

    public decimal EosBury { get; set; }

    public decimal EosOt { get; set; }

    public decimal EosSum { get; set; }

    public decimal EreuseSum { get; set; }

    public decimal ErecSum { get; set; }

    public decimal EaltSum { get; set; }

    public decimal EburnSum { get; set; }

    public decimal EburySum { get; set; }

    public decimal EotSum { get; set; }

    public decimal EtransSum { get; set; }

    public decimal EdisposeSum { get; set; }

    public decimal Esum { get; set; }

    public string Edesc { get; set; } = null!;

    public string CreateUser { get; set; } = null!;

    public DateTime CreateDate { get; set; }

    public string TransUser { get; set; } = null!;

    public DateTime? TransDate { get; set; }
}
