using System.ComponentModel.DataAnnotations.Schema;
namespace esg_mcp_server.Data
{
    public sealed class usp_EsgCheckR1_getList
    {
        public string? OrgCode { get; set; }
        public string? cYear { get; set; }
        public string? DeptNameS { get; set; }
        public string? DeptArea { get; set; }
        public string? DeptAreaNM { get; set; }
        public string? EsgBG { get; set; }
        public string? EsgBGNM { get; set; }
        public string? MfBaseYN { get; set; }
        [Column("原物料")]
        public string? RawMaterials { get; set; }
        [Column("水資源")]
        public string? WaterResources { get; set; }
        [Column("能源")]
        public string? Energy { get; set; }
        [Column("廢棄物")]
        public string? Waste { get; set; }
        [Column("非溫室氣體")]
        public string? NonGHG { get; set; }
        [Column("溫室氣體")]
        public string? GHG { get; set; }
        [Column("產品資訊")]
        public string? ProductInfo { get; set; }
        [Column("採購資訊")]
        public string? ProcurementInfo { get; set; }
        [Column("職安衛")]
        public string? Ohs { get; set; }
        [Column("廠區證照管理")]
        public string? PlantLicenseMgmt { get; set; }
        [Column("消防安全")]
        public string? FireSafety { get; set; }
        [Column("客戶滿意度")]
        public string? CustomerSatisfaction { get; set; }
        [Column("課程教育訓練")]
        public string? TrainingCourses { get; set; }
    }

}
