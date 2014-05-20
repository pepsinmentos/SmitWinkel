using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace SmitWinkel.CustomRoutes
{
    public class CultureRouteConstraint : IRouteConstraint
    {
        public bool Match(HttpContextBase httpContext,
            Route route,
            string parameterName,
            RouteValueDictionary values,
            RouteDirection routeDirection)
        {
            if (!values.ContainsKey(parameterName))
                return false;
            string potentialCultureName = (string)values[parameterName];
            return CultureFormatChecker.FormattedAsCulture(potentialCultureName);
        }
    }
}