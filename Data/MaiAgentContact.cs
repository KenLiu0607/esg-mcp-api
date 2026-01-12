using System;
using System.Collections.Generic;

namespace esg_mcp_server.Data;

public partial class MaiAgentContact
{
    public Guid ContactId { get; set; }

    public string UserId { get; set; } = null!;

    public bool Emable { get; set; }

    public DateOnly CreateDate { get; set; }
}
