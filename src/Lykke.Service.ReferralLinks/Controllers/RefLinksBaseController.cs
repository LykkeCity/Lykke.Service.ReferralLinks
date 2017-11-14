﻿using Common;
using Common.Log;
using Lykke.Blue.Service.ReferralLinks.Core.Domain.Exceptions;
using Lykke.Blue.Service.ReferralLinks.Core.Domain.Offchain;
using Lykke.Blue.Service.ReferralLinks.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Lykke.Blue.Service.ReferralLinks.Controllers
{
    public class RefLinksBaseController : Controller
    {
        private readonly ILog _log;

        public RefLinksBaseController(ILog log)
        {
            _log = log;
        }

        protected async Task<ObjectResult> LogAndReturnInternalServerError<T>(T request, ControllerContext controllerCtx, Exception ex)
        {
            await LogError(request, controllerCtx, ex);
            return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
        }

        protected async Task<ObjectResult> LogOffchainExceptionAndReturn<T>(T request, ControllerContext controllerCtx, OffchainException ex)
        {
            await LogError(request, controllerCtx, new Exception($"OffchainException: {ex.ToJson()}"));
            return StatusCode((int)HttpStatusCode.InternalServerError, new { ex.OffchainExceptionMessage, ex.OffchainExceptionCode, ex.Message } );
        }

        protected async Task<ObjectResult> LogTraderExceptionAndReturn<T>(T request, ControllerContext controllerCtx, TradeException ex)
        {
            await LogError(request, controllerCtx, new Exception($"TradeException: {ex.ToJson()}"));
            return StatusCode((int)HttpStatusCode.InternalServerError, new { TradeExceptionType = ex.Type.ToString(), ex.Message });
        }

        protected async Task<ObjectResult> LogAndReturnBadRequest<T>(T request, ControllerContext controllerCtx, string info)
        {
            await LogWarn(request, controllerCtx, info);
            return BadRequest(info);
        }

        protected async Task LogInfo<T>(T callParams, ControllerContext controllerCtx, string info)
        {
            await _log.WriteInfoAsync(controllerCtx.GetExecutongControllerAndAction(), (new { callParams }).ToJson(), info, DateTime.Now);
        }

        protected async Task LogWarn<T>(T callParams, ControllerContext controllerCtx, string info)
        {
            await _log.WriteWarningAsync(controllerCtx.GetExecutongControllerAndAction(), (new { callParams }).ToJson(), info, DateTime.Now);
        }

        protected async Task LogError<T>(T callParams, ControllerContext controllerCtx, Exception ex)
        {
            await _log.WriteErrorAsync(controllerCtx.GetExecutongControllerAndAction(), (new { callParams }).ToJson(), ex, DateTime.Now);
        }
    }
}