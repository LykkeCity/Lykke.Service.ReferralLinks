﻿using System.Threading.Tasks;

namespace Lykke.blue.Service.ReferralLinks.Core.Services
{
    public interface IFirebaseService
    {
        Task<string> GenerateUrl(string id);
    }
}
