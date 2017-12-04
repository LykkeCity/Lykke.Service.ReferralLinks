﻿using AutoMapper;
using Lykke.blue.Service.ReferralLinks.AzureRepositories.DTOs;
using Lykke.blue.Service.ReferralLinks.AzureRepositories.ReferralLink;
using Lykke.blue.Service.ReferralLinks.Core.Domain.ReferralLink;
using Microsoft.WindowsAzure.Storage.Table;

namespace Lykke.blue.Service.ReferralLinks.AzureRepositories
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            //To entities
            CreateMap<IReferralLink, ReferralLinkEntity>();
                //.ForMember(dest => dest.State, opt => opt.MapFrom(src => src.State.ToString()))
                //.ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.Type));

            CreateMap<IReferralLinkClaim, ReferralLinkClaimEntity>();

            ForAllMaps((map, cfg) =>
            {
                if (map.DestinationType.IsSubclassOf(typeof(TableEntity)))
                {
                    cfg.ForMember("ETag", opt => opt.Ignore());
                    cfg.ForMember("PartitionKey", opt => opt.Ignore());
                    cfg.ForMember("RowKey", opt => opt.Ignore());
                    cfg.ForMember("Timestamp", opt => opt.Ignore());
                }
            });

            //From entities
            CreateMap<ReferralLinkEntity, ReferralLinkDto>();
                //.ForMember(dest => dest.State, opt => opt.MapFrom(src => Enum.Parse<ReferralLinkState>(src.State)))
                //.ForMember(dest => dest.Type, opt => opt.MapFrom(src => Enum.Parse<ReferralLinkType>(src.Type)));

            CreateMap<ReferralLinkClaimEntity, ReferralLinkClaimsDto>();
        }
    }
}
