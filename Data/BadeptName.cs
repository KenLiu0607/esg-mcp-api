using System;
using System.Collections.Generic;

namespace esg_mcp_server.Data;

public partial class BadeptName
{
    public string OrgCode { get; set; } = null!;

    public string LanguageId { get; set; } = null!;

    public string DeptNameS { get; set; } = null!;

    public string DeptName { get; set; } = null!;

    public string BranchNameS { get; set; } = null!;

    public string BranchName { get; set; } = null!;

    public string CreateUser { get; set; } = null!;

    public DateTime CreateDate { get; set; }

    public string TransUser { get; set; } = null!;

    public DateTime TransDate { get; set; }

    public int LockId { get; set; }
}
