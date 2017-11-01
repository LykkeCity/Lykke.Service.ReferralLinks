﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lykke.Service.ReferralLinks.Core.Settings.ServiceSettings
{
    public class DynamicLinkSettings
    {
        public string ApiUrl { get; set; }
        public string DynamicLinkDomain { get; set; }
        public string Link { get; set; }
        public AndroidInfoSettings AndroidInfo { get; set; }
        public IosInfoSettings IosInfo { get; set; }
    }
}
