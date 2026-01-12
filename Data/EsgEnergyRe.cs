using System;
using System.Collections.Generic;

namespace esg_mcp_server.Data;

public partial class EsgEnergyRe
{
    public string OrgCode { get; set; } = null!;

    public string CYear { get; set; } = null!;

    public string OpName { get; set; } = null!;

    public string EsgEngType { get; set; } = null!;

    public int EcOpGen { get; set; }

    public int EcOpReg { get; set; }

    public int EcOpSum { get; set; }

    public int EcSelfGen { get; set; }

    public int EcSelfBio { get; set; }

    public int EcSelfReg { get; set; }

    public int EcSelfSum { get; set; }

    public int EcSum { get; set; }

    public int StOpGen { get; set; }

    public int StOpReg { get; set; }

    public int StOpSum { get; set; }

    public int StSelfGen { get; set; }

    public int StSelfBio { get; set; }

    public int StSelfReg { get; set; }

    public int StSelfSum { get; set; }

    public int StSum { get; set; }

    public int TmOp { get; set; }

    public int TmSelf { get; set; }

    public int RfOp { get; set; }

    public int RfSelf { get; set; }

    public int SecBio { get; set; }

    public int SecNonReg { get; set; }

    public int SecReg { get; set; }

    public int SecSum { get; set; }

    public int Sst { get; set; }

    public int FfCoal { get; set; }

    public int FfOil { get; set; }

    public int Ffdiesel { get; set; }

    public int FfLpg { get; set; }

    public int FfNg { get; set; }

    public int AfRubber { get; set; }

    public int AfSrf { get; set; }

    public int AfSlag { get; set; }

    public int AfMud { get; set; }

    public int AfHydrogen { get; set; }

    public int Biogas { get; set; }

    public int Biothick { get; set; }

    public int BioBark { get; set; }

    public int BioWood { get; set; }

    public int BioArg { get; set; }

    public int BioWpelt { get; set; }

    public decimal EcOpGenHv { get; set; }

    public decimal EcOpRegHv { get; set; }

    public decimal EcSelfGenHv { get; set; }

    public decimal EcSelfBioHv { get; set; }

    public decimal EcSelfRegHv { get; set; }

    public decimal StOpGenHv { get; set; }

    public decimal StOpRegHv { get; set; }

    public decimal StSelfGenHv { get; set; }

    public decimal StSelfBioHv { get; set; }

    public decimal StSelfRegHv { get; set; }

    public decimal TmOpHv { get; set; }

    public decimal TmSelfHv { get; set; }

    public decimal RfOpHv { get; set; }

    public decimal RfSelfHv { get; set; }

    public decimal SecBioHv { get; set; }

    public decimal SecNonRegHv { get; set; }

    public decimal SecRegHv { get; set; }

    public decimal SstHv { get; set; }

    public decimal FfCoalHv { get; set; }

    public decimal FfOilHv { get; set; }

    public decimal FfdieselHv { get; set; }

    public decimal FfLpgHv { get; set; }

    public decimal FfNgHv { get; set; }

    public decimal AfRubberHv { get; set; }

    public decimal AfSrfhv { get; set; }

    public decimal AfSlagHv { get; set; }

    public decimal AfMudHv { get; set; }

    public decimal AfHydrogenHv { get; set; }

    public decimal BiogasHv { get; set; }

    public decimal BiothickHv { get; set; }

    public decimal BioBarkHv { get; set; }

    public decimal BioWoodHv { get; set; }

    public decimal BioArgHv { get; set; }

    public decimal BioWpeltHv { get; set; }

    public int EcOpGenGj { get; set; }

    public int EcOpRegGj { get; set; }

    public int EcOpSumGj { get; set; }

    public int EcSelfGenGj { get; set; }

    public int EcSelfBioGj { get; set; }

    public int EcSelfRegGj { get; set; }

    public int EcSelfSumGj { get; set; }

    public int EcSumGj { get; set; }

    public int StOpGenGj { get; set; }

    public int StOpRegGj { get; set; }

    public int StOpSumGj { get; set; }

    public int StSelfGenGj { get; set; }

    public int StSelfBioGj { get; set; }

    public int StSelfRegGj { get; set; }

    public int StSelfSumGj { get; set; }

    public int StSumGj { get; set; }

    public int TmOpGj { get; set; }

    public int TmSelfGj { get; set; }

    public int RfOpGj { get; set; }

    public int RfSelfGj { get; set; }

    public int SecBioGj { get; set; }

    public int SecNonRegGj { get; set; }

    public int SecRegGj { get; set; }

    public int SecSumGj { get; set; }

    public int SstGj { get; set; }

    public int FfCoalGj { get; set; }

    public int FfOilGj { get; set; }

    public int FfdieselGj { get; set; }

    public int FfLpgGj { get; set; }

    public int FfNgGj { get; set; }

    public int AfRubberGj { get; set; }

    public int AfSrfgj { get; set; }

    public int AfSlagGj { get; set; }

    public int AfMudGj { get; set; }

    public int AfHydrogenGj { get; set; }

    public int BiogasGj { get; set; }

    public int BiothickGj { get; set; }

    public int BioBarkGj { get; set; }

    public int BioWoodGj { get; set; }

    public int BioArgGj { get; set; }

    public int BioWpeltGj { get; set; }

    public int FuelSumGj { get; set; }

    public int EngSumGj { get; set; }

    public int ConSumGj { get; set; }

    public int EcOpGenMwh { get; set; }

    public int EcOpRegMwh { get; set; }

    public int EcOpSumMwh { get; set; }

    public int EcSelfGenMwh { get; set; }

    public int EcSelfBioMwh { get; set; }

    public int EcSelfRegMwh { get; set; }

    public int EcSelfSumMwh { get; set; }

    public int EcSumMwh { get; set; }

    public int StOpGenMwh { get; set; }

    public int StOpRegMwh { get; set; }

    public int StOpSumMwh { get; set; }

    public int StSelfGenMwh { get; set; }

    public int StSelfBioMwh { get; set; }

    public int StSelfRegMwh { get; set; }

    public int StSelfSumMwh { get; set; }

    public int StSumMwh { get; set; }

    public int TmOpMwh { get; set; }

    public int TmSelfMwh { get; set; }

    public int RfOpMwh { get; set; }

    public int RfSelfMwh { get; set; }

    public int SecBioMwh { get; set; }

    public int SecNonRegMwh { get; set; }

    public int SecRegMwh { get; set; }

    public int SecSumMwh { get; set; }

    public int SstMwh { get; set; }

    public int FfCoalMwh { get; set; }

    public int FfOilMwh { get; set; }

    public int FfdieselMwh { get; set; }

    public int FfLpgMwh { get; set; }

    public int FfNgMwh { get; set; }

    public int AfRubberMwh { get; set; }

    public int AfSrfmwh { get; set; }

    public int AfSlagMwh { get; set; }

    public int AfMudMwh { get; set; }

    public int AfHydrogenMwh { get; set; }

    public int BiogasMwh { get; set; }

    public int BiothickMwh { get; set; }

    public int BioBarkMwh { get; set; }

    public int BioWoodMwh { get; set; }

    public int BioArgMwh { get; set; }

    public int BioWpeltMwh { get; set; }

    public int FuelSumMwh { get; set; }

    public int EngSumMwh { get; set; }

    public int ConSumMwh { get; set; }

    public string EcChangeMemo { get; set; } = null!;

    public string EcFutureMemo { get; set; } = null!;

    public string StChangeMemo { get; set; } = null!;

    public string StFutureMemo { get; set; } = null!;

    public string SecChangeMemo { get; set; } = null!;

    public string SecFutureMemo { get; set; } = null!;

    public string FuelChangeMemo { get; set; } = null!;

    public string FuelFutureMemo { get; set; } = null!;

    public string CreateUser { get; set; } = null!;

    public DateTime CreateDate { get; set; }

    public string TransUser { get; set; } = null!;

    public DateTime? TransDate { get; set; }
}
