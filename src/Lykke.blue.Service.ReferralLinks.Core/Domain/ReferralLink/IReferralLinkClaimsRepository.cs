﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lykke.blue.Service.ReferralLinks.Core.Domain.ReferralLink
{
    public interface IReferralLinkClaimsRepository
    {
        Task<IReferralLinkClaim> Create(IReferralLinkClaim referralLinkClaims);
        Task<IEnumerable<IReferralLinkClaim>> GetClaimsForRefLinks(IEnumerable<string> refLinkIds);
        Task<IReferralLinkClaim> Update(IReferralLinkClaim referralLinkClaims);
        Task<IReferralLinkClaim> UpdateAsyncWithETagCheck(IReferralLinkClaim referralLinkClaim); //must be used for updating ref link tate upon claim
    }
}
