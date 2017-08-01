﻿using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Grand.Core.Data;

namespace Grand.Core.Http
{
    /// <summary>
    /// Represents middleware that checks whether request is for keep alive
    /// </summary>
    public class KeepAliveMiddleware
    {
        #region Fields

        private readonly RequestDelegate _next;

        #endregion

        #region Ctor

        public KeepAliveMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Invoke middleware actions
        /// </summary>
        /// <param name="context">HTTP context</param>
        /// <param name="webHelper">Web helper</param>
        /// <returns>Task</returns>
        public async Task Invoke(Microsoft.AspNetCore.Http.HttpContext context, IWebHelper webHelper)
        {
            //TODO test. ensure that no guest record is created

            //whether database is installed
            if (DataSettingsHelper.DatabaseIsInstalled())
            {
                //keep alive page requested (we ignore it to prevent creating a guest customer records)
                var keepAliveUrl = string.Format("{0}keepalive/index", webHelper.GetStoreLocation());
                if (webHelper.GetThisPageUrl(false).StartsWith(keepAliveUrl, StringComparison.OrdinalIgnoreCase))
                    return;
            }
            //or call the next middleware in the request pipeline
            await _next(context);
        }

        #endregion
    }
}
