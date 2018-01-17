﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;

namespace NFine.API.Attribute
{
    /// <summary>
    /// 权限拦截器
    /// </summary>
    public class ApiAuthorizeAttribute : AuthorizeAttribute
    {
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            if (actionContext.Request.Method == HttpMethod.Options)
            {
                actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Accepted);
                return;
            }
        }
    }
}