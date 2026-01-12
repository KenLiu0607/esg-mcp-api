using System;
using System.Collections.Generic;

namespace esg_mcp_server.Data;

public partial class Baapconfig
{
    public string ApkeyId { get; set; } = null!;

    public string IsEncrypt { get; set; } = null!;

    public string KeyValue { get; set; } = null!;

    public string KeyValueEncrypt { get; set; } = null!;

    public string Remarks { get; set; } = null!;

    public string CEnable { get; set; } = null!;

    public string CreateUser { get; set; } = null!;

    public DateTime CreateDate { get; set; }

    public string TransUser { get; set; } = null!;

    public DateTime TransDate { get; set; }

    public int LockId { get; set; }
}
