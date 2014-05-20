﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SmitWinkel.CustomRoutes
{
    public class GlobalisationRouteHandler : MvcRouteHandler
    {
        string CultureValue
        {
            get
            {
                return (string)RouteDataValues[GlobalisedRoute.CultureKey];
            }
        }
        
        RouteValueDictionary RouteDataValues { get; set; }

        protected override IHttpHandler GetHttpHandler(RequestContext requestContext)
        {
            RouteDataValues = requestContext.RouteData.Values;
            CultureManager.SetCulture(CultureValue);
            return base.GetHttpHandler(requestContext);
        }
    }
}