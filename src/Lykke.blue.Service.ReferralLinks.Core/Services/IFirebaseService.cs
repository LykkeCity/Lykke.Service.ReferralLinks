﻿using System.Threading.Tasks;

namespace Lykke.Blue.Service.ReferralLinks.Core.Services
{
    public interface IFirebaseService
    {
        Task<string> GenerateUrl(string id);
    }
}