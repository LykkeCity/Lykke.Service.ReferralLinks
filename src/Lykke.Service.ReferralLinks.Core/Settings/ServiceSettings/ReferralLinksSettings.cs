﻿namespace Lykke.Service.ReferralLinks.Core.Settings.ServiceSettings
{
    public class ReferralLinksSettings
    {
        public DbSettings Db { get; set; }
        public BitcoinCoreSettings BitCoin { get; set; }
        public Services Services { get; set; }
    }
}
