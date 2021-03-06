﻿using Microsoft.AspNetCore.Mvc;

namespace Lykke.blue.Service.ReferralLinks.Extensions
{
    public static class ControllerExtensions
    {
        public static string GetControllerAndAction(this ControllerContext contContext)
        {
            return $"api/{contContext.RouteData.Values["controller"].ToString()}/{contContext.RouteData.Values["action"].ToString()}";
        }
    }
}
