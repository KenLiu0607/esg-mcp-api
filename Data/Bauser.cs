using System;
using System.Collections.Generic;

namespace esg_mcp_server.Data;

public partial class Bauser
{
    public string UserId { get; set; } = null!;

    public string CodeUserKind { get; set; } = null!;

    public string CompanyId { get; set; } = null!;

    public string OrgCode { get; set; } = null!;

    public string OpId { get; set; } = null!;

    public string UserName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string UserTitle { get; set; } = null!;

    public string UserGroupId { get; set; } = null!;

    public byte ErrorCount { get; set; }

    public string LanguageId { get; set; } = null!;

    public DateOnly? DisabledDate { get; set; }

    public string CEnable { get; set; } = null!;

    public string CreateUser { get; set; } = null!;

    public DateTime CreateDate { get; set; }

    public string TransUser { get; set; } = null!;

    public DateTime TransDate { get; set; }

    public int LockId { get; set; }

    public ICollection<MaiAgentContact>? MaiAgentContacts { get; set; }
}
