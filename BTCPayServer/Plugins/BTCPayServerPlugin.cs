using BTCPayServer.Abstractions.Models;
using BTCPayServer.Models;

namespace BTCPayServer.Plugins
{
    public class BTCPayServerPlugin : BaseBTCPayServerPlugin
    {
        public override string Identifier { get; } = nameof(BTCPayServer);
        public override string Name { get; } = "DCO Gateway";
        public override string Description { get; } = "DCO Gateway core system";

    }
}
