using System;
using System.Collections.Generic;

namespace esg_mcp_server.Data;

public partial class Baotuser
{
    public string OtuserId { get; set; } = null!;

    public string CodeUserKind { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string LastPassword { get; set; } = null!;

    public DateOnly PasswordChange { get; set; }

    public string PasswordHint { get; set; } = null!;

    public byte ErrorCount { get; set; }

    public string CEnable { get; set; } = null!;

    public string CreateUser { get; set; } = null!;

    public DateTime CreateDate { get; set; }

    public string TransUser { get; set; } = null!;

    public DateTime TransDate { get; set; }

    public int LockId { get; set; }
}
