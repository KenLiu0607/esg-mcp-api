using System;
using System.Collections.Generic;

namespace esg_mcp_server.Data;

public partial class BarptSub
{
    public string ReportId { get; set; } = null!;

    public short Seqno { get; set; }

    public string? To { get; set; }

    public string? Cc { get; set; }

    public string? Bcc { get; set; }

    public string? ReplyTo { get; set; }

    public bool? IncludeReport { get; set; }

    public string? FileFormat { get; set; }

    public string? Priority { get; set; }

    public string? Subject { get; set; }

    public string? Comment { get; set; }

    public bool? IncludeLink { get; set; }

    public bool? CEnable { get; set; }
}
