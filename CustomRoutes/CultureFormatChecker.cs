using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace SmitWinkel.CustomRoutes
{
    public class CultureFormatChecker
    {
        static Regex _cultureRegexPattern = new Regex(@"^([a-zA-Z]{2})(-[a-zA-Z]{2})?$", RegexOptions.IgnoreCase & RegexOptions.Compiled);

        public static bool FormattedAsCulture(string code)
        {
            if (string.IsNullOrWhiteSpace(code))
                return false;
            return _cultureRegexPattern.IsMatch(code);

        }

    }
}