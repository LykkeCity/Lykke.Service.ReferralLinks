﻿using System;
using Autofac;
using Common.Log;

namespace Lykke.Blue.Service.ReferralLinks.Client
{
    public static class AutofacExtension
    {
        public static void RegisterReferralLinksClient(this ContainerBuilder builder, string serviceUrl, ILog log)
        {
            if (builder == null) throw new ArgumentNullException(nameof(builder));
            if (serviceUrl == null) throw new ArgumentNullException(nameof(serviceUrl));
            if (log == null) throw new ArgumentNullException(nameof(log));
            if (string.IsNullOrWhiteSpace(serviceUrl))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(serviceUrl));

            builder.RegisterInstance(new ReferralLinksClient(serviceUrl, log)).As<IReferralLinksClient>().SingleInstance();
        }
    }
}