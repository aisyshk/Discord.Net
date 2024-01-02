using Discord.API;

namespace Discord.Rest;

public partial class Routes
{
    public static ApiRoute<AuditLog> GetAuditLog(ulong guildId)
        => new (nameof(GetAuditLog),
            RequestMethod.Get,
            $"guilds/{guildId}/audit-logs",
            (ScopeType.Guild, guildId));
}
